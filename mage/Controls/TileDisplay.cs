using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mage.Controls;

public partial class TileDisplay : Control
{


    #region Properties
    /// <summary>
    /// List of <see cref="Drawable"/>s, each representing a rectangle that should be drawn on the image
    /// </summary>
    private List<Drawable> Drawables { get; set; } = new();

    /// <summary>
    /// Image that is displayed as the background image
    /// </summary>
    public Image TileImage
    {
        get => BackgroundImage;
        set
        {
            if (BackgroundImage != null) BackgroundImage.Dispose();
            BackgroundImage = value;
            ScaleImage();
        }
    }

    /// <summary>
    /// Width and Height of a tile
    /// </summary>
    public int TileSize { get; set; } = 16;

    /// <summary>
    /// Whether to show a tile grid or not
    /// </summary>
    public bool ShowGrid
    {
        get => showGrid;
        set
        {
            showGrid = value;
            Invalidate();
        }
    }
    private bool showGrid = false;
    public int GridCellWidth
    {
        get;
        set
        {
            if (field == value) return;
            field = value;
            Invalidate();
        }
    } = 16;
    public int GridCellHeight
    {
        get;
        set
        {
            if (field == value) return;
            field = value;
            Invalidate();
        }
    } = 16;

    /// <summary>
    /// This is a bad fix for the replacement of the OAM view
    /// </summary>
    public bool ShowOamOrigin
    {
        get => showOamOrigin;
        set
        {
            showOamOrigin = value;
            Invalidate();
        }
    }
    private bool showOamOrigin = false;

    /// <summary>
    /// Pen used for the tile grid if <see cref="ShowGrid"/> is set to true
    /// </summary>
    public Pen GridPen { get; set; } = Pens.White;

    /// <summary>
    /// Scale of the display
    /// </summary>
    public int Zoom
    {
        get => zoom;
        set
        {
            zoom = value;
            if (BackgroundImage == null) return;
            ScaleImage();
        }
    }
    private int zoom = 0;

    /// <summary>
    /// The origin from where to calculate the tile positions in pixels
    /// </summary>
    public Point TileGridOrigin { get; set; } = new(0, 0);
    #endregion

    #region Events
    public class TileDisplayArgs : MouseEventArgs
    {
        public int TileSize { get; }
        public Point TilePixelPosition => new Point(TileIndexPosition.X * TileSize, TileIndexPosition.Y * TileSize);
        public Point TileIndexPosition => new Point(PixelPosition.X / TileSize, PixelPosition.Y / TileSize);
        public Point PixelPosition { get; }

        public TileDisplayArgs(
            MouseButtons button,
            int clicks,
            Point pixelPosition,
            Point realPosition,
            int tileSize,
            int delta
            ) : base(button, clicks, realPosition.X, realPosition.Y, delta)
        {
            PixelPosition = pixelPosition;
            TileSize = tileSize;
        }
    }

    public event EventHandler<TileDisplayArgs>? TileMouseDown;
    public event EventHandler<TileDisplayArgs>? TileMouseUp;
    public event EventHandler<TileDisplayArgs>? TileMouseMove;

    public event EventHandler<MouseEventArgs>? Scrolled;

    private TileDisplayArgs generateArgs(MouseEventArgs e)
    {
        Point pixelPos = new Point(e.X >> zoom, e.Y >> zoom);
        return new TileDisplayArgs(
            e.Button,
            e.Clicks,
            pixelPos,
            new Point(e.X - TileGridOrigin.X, e.Y - TileGridOrigin.Y),
            TileSize,
            e.Delta
        );
    }
    #endregion

    // CTOR
    public TileDisplay()
    {
        InitializeComponent();

        // Setup
        SetStyle(ControlStyles.AllPaintingInWmPaint |
             ControlStyles.OptimizedDoubleBuffer |
             ControlStyles.Selectable |
             ControlStyles.UserPaint, true);
        BackgroundImageLayout = ImageLayout.Stretch;
        BackColor = Color.FromArgb(32, 32, 32);
        TabStop = false;

        Drawables.Clear();

        //Bind Events
        MouseDown += (object? s, MouseEventArgs e) => TileMouseDown?.Invoke(this, generateArgs(e));
        MouseUp += (object? s, MouseEventArgs e) => TileMouseUp?.Invoke(this, generateArgs(e));
        MouseMove += (object? s, MouseEventArgs e) => TileMouseMove?.Invoke(this, generateArgs(e));
    }

    // METHODS
    public void AddDrawable(Drawable drawable)
    {
        Drawables.Add(drawable);
        drawable.InvalidateDrawable = InvalidateDrawable;
    }

    public Drawable GetDrawable(int index) => Drawables[index];

    public Rectangle ScaleDrawable(Drawable drawable)
    {
        Rectangle r = drawable.Rectangle;
        r.Size = new Size((r.Width << Zoom) - drawable.Indent, (r.Height << Zoom) - drawable.Indent);
        r.Location = new Point(r.X << Zoom, r.Y << Zoom);
        return r;
    }

    private void InvalidateDrawable(Drawable drawable)
    {
        Rectangle r = Rectangle.Union(drawable.Rectangle, drawable.OldRectangle);
        r = new Rectangle(r.X << zoom, r.Y << zoom, r.Width << zoom, r.Height << zoom);
        r.Inflate(drawable.Indent << zoom, drawable.Indent << zoom);
        r.Inflate(1, 1);
        Invalidate(r);
    }

    public void ResetDrawables()
    {
        Drawables.Clear();
    }

    private void ScaleImage()
    {
        if (BackgroundImage == null)
        {
            Size = Size.Empty;
            return;
        }
        Size = new Size(BackgroundImage.Width << Zoom, BackgroundImage.Height << Zoom);
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        if (ShowGrid)
        {
            for (int i = 0; i < TileImage.Width / GridCellWidth; i++)
                pe.Graphics.DrawLine(GridPen, (i * GridCellWidth) << Zoom, 0, (i * GridCellWidth) << Zoom, TileImage.Height << Zoom);

            for (int i = 0; i < TileImage.Height / GridCellHeight; i++)
                pe.Graphics.DrawLine(GridPen, 0, (i * GridCellHeight) << Zoom, TileImage.Width << Zoom, (i * GridCellHeight) << Zoom);
        }

        if (ShowOamOrigin)
        {
            pe.Graphics.DrawLine(GridPen, 0, OAM.FrameOriginY << Zoom, OAM.XPosRange << Zoom, OAM.FrameOriginY << Zoom);
            pe.Graphics.DrawLine(GridPen, OAM.FrameOriginX << Zoom, 0, OAM.FrameOriginX << Zoom, OAM.YPosRange << Zoom);
        }

        foreach (Drawable d in Drawables)
        {
            if (!d.Visible) continue;

            //Scale the rectangle to the zoom level
            Rectangle r = ScaleDrawable(d);

            foreach (Pen p in d.DrawPens) pe.Graphics.DrawRectangle(p, r);
        }
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        pevent.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
        pevent.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
        base.OnPaintBackground(pevent);
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
        Scrolled?.Invoke(this, e);
        base.OnMouseWheel(e);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        if (!this.Focused) this.Focus();
    }
}
