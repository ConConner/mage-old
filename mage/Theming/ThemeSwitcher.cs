using mage.Controls;
using mage.Theming.CustomControls;
using mage.Warnings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.Versioning;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace mage.Theming
{
    [SupportedOSPlatform("windows")]
    public static class ThemeSwitcher
    {
        /// <summary>
        /// Project Wide dictionary with all Color Themes
        /// </summary>
        public static Dictionary<string, ColorTheme> Themes = new Dictionary<string, ColorTheme>()
        { };

        public const string StandardThemeName = "Mage Old";
        /// <summary>
        /// The old color scheme of MAGE
        /// </summary>
        public static ColorTheme StandardTheme { get; } = new ColorTheme()
        {
            Colors = new Dictionary<string, Color>() {
            {"TextColor",  ColorTranslator.FromHtml("#000000")},
            {"BackgroundColor",  ColorTranslator.FromHtml("#F0F0F0")},
            {"PrimaryOutline",  ColorTranslator.FromHtml("#BCBCBC")},
            {"SecondaryOutline",  ColorTranslator.FromHtml("#DCDCDC")},
            {"AccentColor",  ColorTranslator.FromHtml("#0078D7")},
            }
        };

        public const string StandardDarkThemeName = "Mage Dark";
        /// <summary>
        /// A new dark color scheme for MAGE, currently based on Visual Studio 2022
        /// </summary>
        public static ColorTheme StandardDarkTheme { get; } = new ColorTheme()
        {
            Colors = new Dictionary<string, Color>() {
            {"TextColor",  ColorTranslator.FromHtml("#DCDCDC")},
            {"BackgroundColor",  ColorTranslator.FromHtml("#1E1E1E")},
            {"PrimaryOutline",  ColorTranslator.FromHtml("#5F5F5F")},
            {"SecondaryOutline",  ColorTranslator.FromHtml("#3D3D3D")},
            {"AccentColor",  ColorTranslator.FromHtml("#7160e8")},
            }
        };


        /// <summary>
        /// The currently used Color Theme
        /// </summary>
        private static ColorTheme projectTheme;
        private static string projectThemeName;
        public static string ProjectThemeName
        {
            get => projectThemeName;
            set
            {
                if (!Themes.ContainsKey(value))
                {
                    if (value == ThemeSwitcher.StandardThemeName) Themes.Add(ThemeSwitcher.StandardThemeName, StandardTheme);
                    else if (value == ThemeSwitcher.StandardDarkThemeName) Themes.Add(ThemeSwitcher.StandardDarkThemeName, StandardDarkTheme);
                    else
                    {
                        ProjectThemeName = ThemeSwitcher.StandardThemeName;
                        value = ThemeSwitcher.StandardThemeName;
                    }
                }
                projectThemeName = value;
                ProjectTheme = Themes[value];
            }
        }
        public static ColorTheme ProjectTheme
        {
            get => projectTheme;
            set
            {
                projectTheme = value;
                foreach (Form frm in Application.OpenForms)
                {
                    ChangeTheme(frm.Controls, frm);
                }
                ThemeChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static event EventHandler<EventArgs> ThemeChanged;


        /// <summary>
        /// Changes the properties of all Controls in <paramref name="container"/> to reflect the current theme
        /// selected in the <see cref="ThemeSwitcher.ProjectTheme"/>. Changes the background color of <paramref name="Base"/> if given.
        /// </summary>
        public static void ChangeTheme(Control.ControlCollection container, Form Base = null)
        {
            Base?.SuspendLayout();

            ColorTheme theme = ProjectTheme;

            if (Base != null)
            {
                if (Base.Tag?.ToString() == "unthemed") return;

                Base.BackColor = theme.BackgroundColor;
                Base.ForeColor = theme.TextColor;

                var f = Base.GetType()
                    .GetField("components", BindingFlags.NonPublic | BindingFlags.Instance);
                if (f?.GetValue(Base) is IContainer c)
                {
                    foreach (IComponent comp in c.Components)
                        if (comp is ContextMenuStrip cms)
                            cms.Renderer = new ContextMenuCustomRenderer();
                }
            }

            foreach (Control control in container)
            {
                if (control is TileView ||
                    control is RoomView ||
                    control.Tag?.ToString() == "unthemed")
                    continue;

                ChangeTheme(control);
            }

            Base?.ResumeLayout();
        }

        /// <summary>
        /// Changes the properties of <paramref name="control"/> to reflect the current theme
        /// selected in the <see cref="ThemeSwitcher.ProjectTheme"/>.
        /// </summary>
        /// <param name="control"></param>
        public static void ChangeTheme(Control control)
        {
            ColorTheme theme = ProjectTheme;

            // ErrorListPanel fully owns its own painting (it's an owner-drawn, virtual-mode
            // ListView under the hood). Map the project theme onto its own theme properties
            // and stop: don't fall through to the generic per-control/ListView handling below,
            // which would attach a second, conflicting set of Draw* handlers to its internal
            // ListView and paint blank text over what it already drew (see ErrorListPanel.cs).
            if (control is ErrorListPanel errorListPanel)
            {
                errorListPanel.ApplyProjectTheme(theme);
                return;
            }

            //base change
            control.BackColor = theme.BackgroundColor;
            control.ForeColor = theme.TextColor;
            control.Invalidate();
            if (control.Tag?.ToString() == "accent") control.BackColor = theme.AccentColor;

            if (control.HasChildren)
            {
                ChangeTheme(control.Controls);
            }

            //Special handeling for special controls
            if (control is FlatComboBox)
            {
                FlatComboBox box = control as FlatComboBox;
                box.BorderColor = theme.PrimaryOutline;
                box.ButtonColor = theme.BackgroundColor;
            }

            if (control is ToolStrip)
            {
                ToolStrip strip = control as ToolStrip;
                strip.Renderer = new MenuStripCustomRenderer(theme);
            }

            if (control is Button)
            {
                Button btn = control as Button;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = theme.PrimaryOutline;
                btn.FlatAppearance.MouseOverBackColor = theme.AccentColor;
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x7F, theme.AccentColor);
            }

            if (control is FlatTextBox)
            {
                FlatTextBox box = control as FlatTextBox;
                box.BorderColor = theme.PrimaryOutline;
            }

            if (control is FlatNumericUpDown)
            {
                FlatNumericUpDown num = control as FlatNumericUpDown;
                num.BorderStyle = BorderStyle.FixedSingle;
                num.BorderColor = theme.PrimaryOutline;
                num.ButtonHighlightColor = theme.AccentColor;
            }

            if (control is FlatTabControl)
            {
                FlatTabControl tab = control as FlatTabControl;
                tab.BorderColor = theme.SecondaryOutline;
            }

            if (control is FlatTrackBar bar)
            {
                bar.TrackColor = theme.SecondaryOutline;
                bar.FillColor = theme.AccentColor;
                bar.ThumbColor = theme.AccentColor;
                bar.BorderColor = theme.PrimaryOutline;
            }

            if (control is LinkLabel)
            {
                LinkLabel lbl = control as LinkLabel;
                lbl.LinkColor = theme.AccentColor;
                lbl.VisitedLinkColor = theme.AccentColor;
            }

            if (control is TreeView)
            {
                TreeView tv = control as TreeView;
                tv.LineColor = theme.PrimaryOutline;
            }

            if (control is ContextMenuStrip ctx)
            {
                ctx.Renderer = new ContextMenuCustomRenderer();
            }

            if (control is Seperator sep)
            {
                sep.Color = theme.SecondaryOutline;
            }

            if (control is ColorBar cbar)
            {
                cbar.MarkerColor = theme.BackgroundColor;
                cbar.BorderColor = theme.PrimaryOutline;
            }

            if (control is HsvColorPicker hsv)
            {
                hsv.MarkerColor = theme.BackgroundColor;
                hsv.BorderColor = theme.PrimaryOutline;
            }

            if (control is DualColorSwatch sw)
            {
                sw.SwatchOutlineColor = theme.SecondaryOutline;
                sw.SwapGlyphColor = theme.PrimaryOutline;
                sw.SwapGlyphHotColor = theme.AccentColor;
            }

            if (control is FlatCheckedListBox clb)
            {
                clb.BackColor = theme.BackgroundColor;
                clb.ForeColor = theme.TextColor;
                clb.BorderColor = theme.PrimaryOutline;
                clb.BorderColorDisabled = theme.PrimaryOutlineDisabled;
                clb.AccentColor = theme.AccentColor;
                clb.CheckColor = theme.TextColorHighlight;
                clb.DisabledTextColor = theme.TextColorDisabled;
                clb.SelectionColor = Color.FromArgb(0x3F, theme.AccentColor);
                clb.Invalidate();
            }

            if (control is RecentColorDisplay rcd)
            {
                rcd.OutlineColor = theme.SecondaryOutline;
                rcd.HighlightColor = theme.AccentColor;
            }

            if (control is DataGridView dgv)
            {
                dgv.BackgroundColor = theme.BackgroundColor;
                dgv.EnableHeadersVisualStyles = false;
                dgv.BorderStyle = BorderStyle.None;
                dgv.GridColor = theme.SecondaryOutline;

                dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
                {
                    BackColor = theme.BackgroundColor,
                    ForeColor = theme.TextColor,
                    SelectionBackColor = theme.BackgroundColor,
                    SelectionForeColor = theme.TextColor
                };
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

                dgv.RowHeadersDefaultCellStyle = new DataGridViewCellStyle()
                {
                    BackColor = theme.BackgroundColor,
                    ForeColor = theme.TextColor,
                };
                dgv.DefaultCellStyle = new DataGridViewCellStyle()
                {
                    BackColor = theme.BackgroundColor,
                    ForeColor = theme.TextColor,
                    SelectionBackColor = theme.AccentColor,
                    SelectionForeColor = theme.TextColorHighlight
                };

                dgv.CellPainting += (_, e) =>
                {

                    if (e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                        dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
                    {
                        bool isSelected = (e.State & DataGridViewElementStates.Selected) != 0;

                        var backColor = isSelected ? theme.AccentColor : theme.BackgroundColor;
                        var textColor = isSelected ? theme.TextColorHighlight : theme.TextColor;

                        using var backBrush = new SolidBrush(backColor);
                        using var textBrush = new SolidBrush(textColor);
                        using var gridPen = new Pen(theme.SecondaryOutline);

                        // fill background
                        e.Graphics.FillRectangle(backBrush, e.CellBounds);

                        // draw text
                        var text = e.FormattedValue?.ToString() ?? "";
                        var textRect = new Rectangle(e.CellBounds.X + 4, e.CellBounds.Y,
                                                   e.CellBounds.Width - 4, e.CellBounds.Height);

                        var sf = new StringFormat
                        {
                            Alignment = StringAlignment.Near,
                            LineAlignment = StringAlignment.Center
                        };

                        e.Graphics.DrawString(text, e.CellStyle.Font, textBrush, textRect, sf);

                        // draw grid lines
                        e.Graphics.DrawLine(gridPen, e.CellBounds.Right - 1, e.CellBounds.Top,
                                           e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                        e.Graphics.DrawLine(gridPen, e.CellBounds.Left, e.CellBounds.Bottom - 1,
                                           e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                        e.Graphics.DrawLine(gridPen, e.CellBounds.Left, e.CellBounds.Top,
                                           e.CellBounds.Left, e.CellBounds.Bottom - 1);

                        e.Handled = true;
                    }
                };
            }

            if (control is ListView lv)
            {
                lv.OwnerDraw = true;
                lv.BorderStyle = BorderStyle.None;
                lv.ColumnWidthChanged += (_, _) => lv.Invalidate(true);

                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };

                lv.DrawColumnHeader += (_, e) =>
                {
                    using var backBrush = new SolidBrush(theme.BackgroundColor);
                    using var textBrush = new SolidBrush(theme.TextColor);
                    using var borderPen = new Pen(theme.SecondaryOutline);

                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    e.Graphics.DrawLine(borderPen, e.Bounds.Left, e.Bounds.Bottom - 1,
                                       e.Bounds.Right - 1, e.Bounds.Bottom - 1);
                    e.Graphics.DrawLine(borderPen, e.Bounds.Right - 1, e.Bounds.Top,
                                       e.Bounds.Right - 1, e.Bounds.Bottom - 1);

                    var textRect = new Rectangle(e.Bounds.X + 4, e.Bounds.Y,
                                                 e.Bounds.Width - 8, e.Bounds.Height);
                    using var font = new Font(lv.Font, FontStyle.Bold);
                    e.Graphics.DrawString(e.Header.Text, font, textBrush, textRect, sf);

                    if (e.ColumnIndex == lv.Columns.Count - 1)
                    {
                        int gapWidth = lv.ClientRectangle.Width - e.Bounds.Right;
                        if (gapWidth > 0)
                        {
                            var gapRect = new Rectangle(e.Bounds.Right, e.Bounds.Y,
                                                        gapWidth, e.Bounds.Height);
                            var oldClip = e.Graphics.Clip;
                            e.Graphics.SetClip(gapRect);
                            e.Graphics.FillRectangle(backBrush, gapRect);
                            e.Graphics.DrawLine(borderPen, gapRect.Left, gapRect.Bottom - 1,
                                               gapRect.Right, gapRect.Bottom - 1);
                            e.Graphics.Clip = oldClip;
                        }
                    }
                };

                lv.DrawItem += (_, e) => e.DrawDefault = lv.View != View.Details;

                lv.DrawSubItem += (_, e) =>
                {
                    bool isSelected = e.Item.Selected;
                    var backColor = isSelected ? theme.AccentColor : theme.BackgroundColor;
                    var textColor = isSelected ? theme.TextColorHighlight : theme.TextColor;

                    using var backBrush = new SolidBrush(backColor);
                    using var textBrush = new SolidBrush(textColor);
                    using var gridPen = new Pen(theme.SecondaryOutline);

                    e.Graphics.FillRectangle(backBrush, e.Bounds);

                    int textX = e.Bounds.X + 4;
                    int availableWidth = e.Bounds.Width - 8;

                    if (e.ColumnIndex == 0 && lv.SmallImageList != null &&
                        e.Item.ImageIndex >= 0 &&
                        e.Item.ImageIndex < lv.SmallImageList.Images.Count)
                    {
                        var img = lv.SmallImageList.Images[e.Item.ImageIndex];
                        int imgY = e.Bounds.Y + (e.Bounds.Height - img.Height) / 2;
                        e.Graphics.DrawImage(img, e.Bounds.X + 4, imgY);
                        textX += img.Width + 4;
                        availableWidth -= img.Width + 4;
                    }

                    var textRect = new Rectangle(textX, e.Bounds.Y,
                                                 availableWidth, e.Bounds.Height);
                    e.Graphics.DrawString(e.SubItem?.Text ?? "", lv.Font,
                                         textBrush, textRect, sf);

                    e.Graphics.DrawLine(gridPen, e.Bounds.Right - 1, e.Bounds.Top,
                                       e.Bounds.Right - 1, e.Bounds.Bottom - 1);
                    e.Graphics.DrawLine(gridPen, e.Bounds.Left, e.Bounds.Bottom - 1,
                                       e.Bounds.Right - 1, e.Bounds.Bottom - 1);
                };
            }
        }

        /// <summary>
        /// This injects new paint events into existing controls to allow for custom colors
        /// </summary>
        public static void InjectPaintOverrides(Control.ControlCollection container)
        {
            foreach (Control control in container)
            {
                //recursively inject the overrides in every child control
                if (control.Controls.Count > 0) InjectPaintOverrides(control.Controls);

                //Special handeling for special controls
                if (control is GroupBox) control.Paint += DrawGroupBox;
                if (control is CheckBox) control.Paint += DrawCheckBox;
                if (control is FlatTextBox)
                {
                    FlatTextBox box = control as FlatTextBox;
                    box.Enter += FocusTextBox;
                    box.Leave += FocusTextBox;
                }
                if (control is Button) control.Paint += DrawButton;
                if (control is Label) control.Paint += DrawLabel;
                if (control is RadioButton) control.Paint += DrawRadioButton;
                if (control is SplitContainer)
                {
                    control.Paint += DrawSplitterHandle;
                    control.Resize += SplitterResize;
                }
                if (control is DataGridView dgv)
                {
                    dgv.EditingControlShowing += DrawDataGridViewControlShowing;
                }
            }
        }

        /// <summary>
        /// Custom Paint event for GroupBoxes
        /// </summary>
        public static void DrawGroupBox(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Graphics g = e.Graphics;
            Color textColor = box.Enabled ? ProjectTheme.TextColor : ProjectTheme.TextColorDisabled;
            Color borderColor = ProjectTheme.SecondaryOutline;

            Brush textBrush = new SolidBrush(textColor);
            Brush borderBrush = new SolidBrush(borderColor);
            Pen borderPen = new Pen(borderBrush);
            SizeF strSize = g.MeasureString(box.Text, box.Font);
            Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                           box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                           box.ClientRectangle.Width - 1,
                                           box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            // Clear text and border
            g.Clear(box.BackColor);

            // Draw text
            g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

            // Drawing Border
            //Left
            g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
            //Right
            g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Bottom
            g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Top1
            g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
            //Top2
            g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
        }

        public static void DrawCheckBox(object sender, PaintEventArgs e)
        {
            CheckBox box = sender as CheckBox;

            bool checkRight = box.CheckAlign == ContentAlignment.MiddleRight;

            Point pt = new Point(e.ClipRectangle.Left, e.ClipRectangle.Top);
            if (checkRight) pt = new(e.ClipRectangle.Right - 14, e.ClipRectangle.Top);
            Rectangle rect = new Rectangle(pt, new Size(13, 13));

            e.Graphics.Clear(ProjectTheme.BackgroundColor);

            //Drawing box
            using (Brush b = box.Checked ? new SolidBrush(ProjectTheme.AccentColor) : new SolidBrush(ProjectTheme.BackgroundColor)) e.Graphics.FillRectangle(b, rect);
            Pen p = box.Checked ? new Pen(ProjectTheme.AccentColor) : box.Enabled ? new Pen(ProjectTheme.PrimaryOutline) : new Pen(ProjectTheme.PrimaryOutlineDisabled) { Alignment = PenAlignment.Inset };
            e.Graphics.DrawRectangle(p, rect);

            if (box.Checked)
            {
                //Drawing the check
                Rectangle r = rect;
                r.Inflate(-3, -3);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawLines(new Pen(ProjectTheme.TextColorHighlight, 2), new Point[]{
                new Point(r.Left, r.Bottom - r.Height /2),
                new Point(r.Left + r.Width /3,  r.Bottom),
                new Point(r.Right, r.Top)});
            }

            //Draw Text
            Brush textBrush = box.Enabled ? new SolidBrush(ProjectTheme.TextColor) : new SolidBrush(ProjectTheme.TextColorDisabled);
            e.Graphics.DrawString(box.Text, box.Font, textBrush, box.Padding.Left + (checkRight ? 0 : 16), box.Padding.Top);
        }

        public static void DrawRadioButton(object sender, PaintEventArgs e)
        {
            RadioButton box = sender as RadioButton;

            Point pt = new Point(e.ClipRectangle.Left, e.ClipRectangle.Top);
            Rectangle rect = new Rectangle(pt, new Size(13, 13));

            e.Graphics.Clear(ProjectTheme.BackgroundColor);

            //Drawing box
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Brush b = box.Checked ? new SolidBrush(ProjectTheme.AccentColor) : new SolidBrush(ProjectTheme.BackgroundColor)) e.Graphics.FillEllipse(b, rect);
            Pen p = box.Checked ? new Pen(ProjectTheme.AccentColor) : box.Enabled ? new Pen(ProjectTheme.PrimaryOutline) : new Pen(ProjectTheme.PrimaryOutlineDisabled) { Alignment = PenAlignment.Inset };
            e.Graphics.DrawEllipse(p, rect);

            if (box.Checked)
            {
                //Drawing the check
                rect.Inflate(-3, -3);
                using (Brush b = new SolidBrush(ProjectTheme.TextColorHighlight)) e.Graphics.FillEllipse(b, rect);
            }

            //Draw Text
            Brush textBrush = box.Enabled ? new SolidBrush(ProjectTheme.TextColor) : new SolidBrush(ProjectTheme.TextColorDisabled);
            e.Graphics.DrawString(box.Text, box.Font, textBrush, box.Padding.Left + 16, box.Padding.Top);
        }

        public static void DrawButton(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Enabled) return;
            e.Graphics.Clear(ProjectTheme.BackgroundColor);

            Pen outlinePen = new Pen(ProjectTheme.PrimaryOutlineDisabled);
            Rectangle buttonRect = new Rectangle(Point.Empty, btn.Size);
            buttonRect.Width--; buttonRect.Height--;
            e.Graphics.DrawRectangle(outlinePen, buttonRect);

            StringFormat s = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            using (Brush b = new SolidBrush(ProjectTheme.TextColorDisabled))
                e.Graphics.DrawString(btn.Text, btn.Font, b, buttonRect, s);
        }

        public static void FocusTextBox(object sender, EventArgs e)
        {
            FlatTextBox box = sender as FlatTextBox;
            box.BorderColor = box.Focused ? ProjectTheme.AccentColor : ProjectTheme.PrimaryOutline;
        }

        public static void DrawLabel(object sender, PaintEventArgs e)
        {
            Label l = sender as Label;

            if (l.Enabled) return;

            Rectangle r = new Rectangle(Point.Empty, l.Size);
            e.Graphics.Clear(ProjectTheme.BackgroundColor);
            using (Brush b = new SolidBrush(ProjectTheme.TextColorDisabled))
                e.Graphics.DrawString(l.Text, l.Font, b, r);
        }

        private static void DrawSplitterHandle(object? sender, PaintEventArgs e)
        {
            var splitter = sender as SplitContainer;
            if (splitter.IsSplitterFixed) return;
            var splitterRect = splitter.SplitterRectangle;

            // Define layout of splitter handle
            int dotsWide = 1;
            int dotsHigh = 10;
            int dotSize = 3;
            int spacing = 3;

            int handleWidth = dotsWide * dotSize + (dotsWide - 1) * spacing;
            int handleHeight = dotsHigh * dotSize + (dotsHigh - 1) * spacing;

            // Swap all variables if orientation is not vertical
            if (splitter.Orientation == Orientation.Horizontal)
            {
                (handleWidth, handleHeight) = (handleHeight, handleWidth);
                (dotsWide, dotsHigh) = (dotsHigh, dotsWide);
            }

            int startX = splitterRect.X + (splitterRect.Width - handleWidth) / 2;
            int startY = splitterRect.Y + (splitterRect.Height - handleHeight) / 2;

            // Draw splitter handle
            using (var brush = new SolidBrush(ProjectTheme.PrimaryOutline))
            {
                for (int row = 0; row < dotsHigh; row++)
                {
                    for (int col = 0; col < dotsWide; col++)
                    {
                        int x = startX + col * (dotSize + spacing);
                        int y = startY + row * (dotSize + spacing);
                        e.Graphics.FillRectangle(brush, x, y, dotSize, dotSize);
                    }
                }
            }
        }
        private static void SplitterResize(object? sender, EventArgs e)
        {
            var splitter = sender as SplitContainer;
            splitter.Invalidate(splitter.SplitterRectangle);
        }

        private static void DrawDataGridViewControlShowing(object? sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is not ComboBox cbb) return;
            cbb.DrawMode = DrawMode.OwnerDrawFixed;
            cbb.BackColor = ProjectTheme.BackgroundColor;
            cbb.ForeColor = ProjectTheme.TextColor;

            cbb.DrawItem -= DataGridComboboxItemDraw;
            cbb.DrawItem += DataGridComboboxItemDraw;
        }

        private static void DataGridComboboxItemDraw(object? sender, DrawItemEventArgs e)
        {
            ComboBox cbb = sender as ComboBox;
            if (cbb == null) return;
            e.DrawBackground();
            var g = e.Graphics;
            using var br = new SolidBrush(projectTheme.TextColor);
            g.DrawString(cbb.Items[e.Index].ToString(),
                         cbb.Font,
                         br, e.Bounds);
        }

        //JSON CONVERSION
        static JsonSerializerOptions jsonOptions = new JsonSerializerOptions()
        {
            Converters =
            {
                new ColorJsonConverter(),
            },
            WriteIndented = true,
        };

        public static string Serialize(object obj)
        {
            return JsonSerializer.Serialize(obj, jsonOptions);
        }

        public static Type Deserialize<Type>(string json)
        {
            return JsonSerializer.Deserialize<Type>(json, jsonOptions);
        }

        public static void TestSerialisation()
        {
            Color toJson = Color.FromArgb(0xFF, 0xF, 0x36);
            string inJson = JsonSerializer.Serialize(toJson);
            Color fromJson = JsonSerializer.Deserialize<Color>(inJson);
        }
    }
}
