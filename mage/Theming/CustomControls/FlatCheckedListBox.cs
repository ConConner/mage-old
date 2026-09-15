using mage.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace mage.Theming.CustomControls;

public class FlatCheckedListBox : CheckedListBox
{
    [DllImport("user32.dll")]
    private static extern IntPtr GetWindowDC(IntPtr hWnd);

    [DllImport("user32.dll")]
    private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

    private const int WM_NCPAINT = 0x0085;
    private const int WM_PAINT = 0x000F;

    public Color BorderColor { get; set; } = Color.FromArgb(60, 60, 60);
    public Color BorderColorDisabled { get; set; } = Color.FromArgb(100, 100, 100);
    public Color AccentColor { get; set; } = Color.FromArgb(0, 120, 215);
    public Color CheckColor { get; set; } = Color.White;
    public Color SelectionColor { get; set; } = Color.FromArgb(45, 45, 48);
    public Color DisabledTextColor { get; set; } = Color.Gray;

    private bool _showSelection = true;

    public bool ShowSelection
    {
        get => _showSelection;
        set
        {
            if (_showSelection != value)
            {
                _showSelection = value;
                Invalidate();
            }
        }
    }

    public FlatCheckedListBox()
    {
        DoubleBuffered = true;
        BorderStyle = BorderStyle.FixedSingle;
        CheckOnClick = true;
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        if (e.Index < 0 || e.Index >= Items.Count) return;

        Graphics g = e.Graphics;
        Rectangle bounds = e.Bounds;

        // Only recognize selection if ShowSelection is enabled
        bool isSelected = ShowSelection && ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
        CheckState checkState = GetItemCheckState(e.Index);

        // 1. Draw Item Background (falls back to BackColor when ShowSelection is false)
        Color bg = isSelected ? SelectionColor : BackColor;
        using (Brush bgBrush = new SolidBrush(bg))
        {
            g.FillRectangle(bgBrush, bounds);
        }

        // 2. Compute Checkbox Geometry
        int boxSize = 13;
        int boxX = bounds.Left + 4;
        int boxY = bounds.Top + (bounds.Height - boxSize) / 2;
        Rectangle boxRect = new Rectangle(boxX, boxY, boxSize, boxSize);

        // 3. Draw Checkbox Box
        bool isChecked = checkState == CheckState.Checked;
        bool isIndeterminate = checkState == CheckState.Indeterminate;

        Color boxFill = (isChecked || isIndeterminate) ? AccentColor : BackColor;
        using (Brush b = new SolidBrush(boxFill))
        {
            g.FillRectangle(b, boxRect);
        }

        Color boxOutline = (isChecked || isIndeterminate)
            ? AccentColor
            : (Enabled ? BorderColor : BorderColorDisabled);

        using (Pen p = new Pen(boxOutline) { Alignment = PenAlignment.Inset })
        {
            g.DrawRectangle(p, boxRect);
        }

        // 4. Draw Check Glyph or Indeterminate Dash
        if (isChecked)
        {
            Rectangle r = boxRect;
            r.Inflate(-2, -2);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen checkPen = new Pen(CheckColor, 2))
            {
                g.DrawLines(checkPen, new Point[]
                {
                new Point(r.Left + 1, r.Bottom - r.Height / 2),
                new Point(r.Left + r.Width / 3 + 1, r.Bottom - 1),
                new Point(r.Right - 1, r.Top + 1)
                });
            }
            g.SmoothingMode = SmoothingMode.Default;
        }
        else if (isIndeterminate)
        {
            Rectangle r = boxRect;
            r.Inflate(-4, -4);
            using (Brush dashBrush = new SolidBrush(CheckColor))
            {
                g.FillRectangle(dashBrush, r);
            }
        }

        // 5. Draw Item Text
        Color textColor = !Enabled ? DisabledTextColor : ForeColor;

        Rectangle textRect = new Rectangle(
            boxRect.Right + 6,
            bounds.Top,
            bounds.Width - (boxRect.Right + 6),
            bounds.Height
        );

        TextRenderer.DrawText(
            g,
            GetItemText(Items[e.Index]),
            Font,
            textRect,
            textColor,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix
        );
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        // Paint custom outer border over native non-client area
        if (m.Msg == WM_NCPAINT || m.Msg == WM_PAINT)
        {
            if (BorderStyle != BorderStyle.None)
            {
                IntPtr hdc = GetWindowDC(Handle);
                if (hdc != IntPtr.Zero)
                {
                    try
                    {
                        using (Graphics g = Graphics.FromHdc(hdc))
                        using (Pen p = new Pen(Enabled ? BorderColor : BorderColorDisabled))
                        {
                            g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                        }
                    }
                    finally
                    {
                        ReleaseDC(Handle, hdc);
                    }
                }
            }
        }
    }

    private const int LB_SETITEMHEIGHT = 0x01A0;

    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

    private int _customItemHeight = 24; // Default comfortable height

    public override int ItemHeight
    {
        get => _customItemHeight;
        set
        {
            if (value < 1) return;
            _customItemHeight = value;

            if (IsHandleCreated)
            {
                // wParam = 0 applies the height to all items in fixed-height list boxes
                SendMessage(Handle, LB_SETITEMHEIGHT, 0, _customItemHeight);
                Invalidate();
            }
        }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);

        // Enforce the custom height as soon as the Win32 handle is ready
        if (_customItemHeight > 0)
        {
            SendMessage(Handle, LB_SETITEMHEIGHT, 0, _customItemHeight);
        }
    }

    protected override void OnFontChanged(EventArgs e)
    {
        base.OnFontChanged(e);

        // Reapply after font changes so the native control doesn't snap back
        if (IsHandleCreated && _customItemHeight > 0)
        {
            SendMessage(Handle, LB_SETITEMHEIGHT, 0, _customItemHeight);
        }
    }

    public event EventHandler<ItemCheckEventArgs> ItemCheckedChanged;

    protected override void OnItemCheck(ItemCheckEventArgs ice)
    {
        base.OnItemCheck(ice);

        if (!IsHandleCreated || IsDisposed)
            return;

        BeginInvoke(new System.Action(() =>
        {
            if (!IsDisposed)
            {
                ItemCheckedChanged?.Invoke(this, ice);
            }
        }));
    }
}
