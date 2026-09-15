using mage.Warnings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace mage
{
    public partial class RoomView : ScrollableControl
    {
        // properties
        public bool HasSelection
        {
            get { return selRect.X != -1; }
        }
        public FormMain Main
        {
            set { main = value; }
        }
        public Room Room
        {
            set
            {
                room = value;
                this.BackgroundImage = new Bitmap(room.Width * 16, room.Height * 16, PixelFormat.Format16bppRgb555);
                this.Size = new Size(BackgroundImage.Width << zoom, BackgroundImage.Height << zoom);
            }
        }
        private int PenDashOffset
        {
            get => (int)wp.DashOffset;
            set
            {
                wp.DashOffset = value % 5;
                bp.DashOffset = (value + 2) % 5;
            }
        }

        // fields
        public Rectangle redRect;
        public Rectangle selRect;
        private Pen rp, wp, bp, mp;
        private int zoom;

        private FormMain main;
        private Room room;

        // rule warnings
        private IReadOnlyDictionary<(int x, int y), List<ClipdataError>>? _errors;
        private readonly List<Rectangle> _errorRects = new();
        public Point? HighlightedWarning = null;
        private Rectangle HighlightedWarningRect
        {
            get
            {
                if (HighlightedWarning is null) return new(-1, -1, 0, 0);
                Point highlightedPoint = new(HighlightedWarning.Value.X * 16 << zoom, HighlightedWarning.Value.Y * 16 << zoom);
                Size s = new(16 << zoom, 16 << zoom);
                Rectangle highlight = new(highlightedPoint, s);
                return highlight;
            }
        }
        private readonly Timer _pulseTimer;
        private float _pulsePhase;
        private readonly SolidBrush _pulseBrush = new(Color.Gold);
        private readonly SolidBrush _pulseHighlightBrush = new(Color.Blue);

        public RoomView()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackgroundImageLayout = ImageLayout.Stretch;
            TabStop = false;

            rp = new Pen(Color.Red);
            wp = new Pen(Color.White);
            bp = new Pen(Color.Black);
            mp = new Pen(Color.FromArgb(0xFF, 0x00, 0x84));

            wp.DashPattern = [2, 3];
            bp.DashPattern = [3, 2];
            PenDashOffset = 0;

            Timer dashAnimationTimer = new Timer { Interval = 100 };
            dashAnimationTimer.Tick += (_, _) =>
            {
                PenDashOffset += 1;
                if (selRect.X != -1)
                {
                    var invalidateArea = selRect;
                    invalidateArea.Inflate(1, 1);
                    Invalidate(invalidateArea);
                }
            };
            dashAnimationTimer.Start();

            _pulseTimer = new Timer { Interval = 33 };
            _pulseTimer.Tick += OnPulseTick;
        }

        private void OnPulseTick(object? sender, EventArgs e)
        {
            _pulsePhase += 0.12f;
            if (_pulsePhase > MathF.Tau)
                _pulsePhase -= MathF.Tau;

            foreach (var rect in _errorRects)
                Invalidate(rect);

            if (HighlightedWarning is not null) Invalidate(HighlightedWarningRect);
        }

        public bool UpdateZoom(int newZoom, bool resize)
        {
            if (zoom == newZoom) { return false; }

            zoom = newZoom;
            RebuildErrorRectangles();

            if (resize)
            {
                this.Size = new Size(BackgroundImage.Width << zoom, BackgroundImage.Height << zoom);
            }

            return true;
        }

        public void Reset()
        {
            int size = (16 << zoom) - 1;
            redRect = new Rectangle(-1, -1, size, size);
            selRect = new Rectangle(-1, -1, size, size);
        }

        public void MoveRed(int x, int y)
        {
            redRect.X = x << (4 + zoom);
            redRect.Y = y << (4 + zoom);
        }

        public void ResizeRed(int w, int h)
        {
            int shift = 4 + zoom;
            redRect.Width = (w << shift) - 1;
            redRect.Height = (h << shift) - 1;
        }

        public void ResizeSelection(Rectangle rect)
        {
            int shift = 4 + zoom;
            selRect = new Rectangle(rect.X << shift, rect.Y << shift,
                (rect.Width << shift) - 1, (rect.Height << shift) - 1);
        }

        public void RedrawAll()
        {
            Redraw(new Rectangle(0, 0, BackgroundImage.Width, BackgroundImage.Height));
        }

        public unsafe void Redraw(Rectangle rect)
        {
            // get rectangles
            rect.X -= 16;
            rect.Y -= 16;
            rect.Width += 32;
            rect.Height += 32;
            Rectangle roomSize = new Rectangle(0, 0, BackgroundImage.Width, BackgroundImage.Height);
            rect.Intersect(roomSize);

            BitmapData dstData = ((Bitmap)this.BackgroundImage).LockBits(roomSize, ImageLockMode.WriteOnly, PixelFormat.Format16bppRgb555);
            int imgWidth = BackgroundImage.Width;
            int dstWidth = rect.Width;

            // fill with black
            ushort* dstPtr = (ushort*)dstData.Scan0;
            dstPtr += rect.Y * imgWidth + rect.X;
            for (int y = 0; y < rect.Height; y++)
            {
                for (int x = 0; x < dstWidth; x++)
                {
                    *dstPtr++ = main.Bg3Color;
                }
                dstPtr += imgWidth - dstWidth;
            }

            // backgrounds
            Rectangle region = new Rectangle(rect.X >> 4, rect.Y >> 4, rect.Width >> 4, rect.Height >> 4);
            Bitmap srcImg = room.vram.Image;
            BitmapData srcData = srcImg.LockBits(new Rectangle(0, 0, 256, srcImg.Height), ImageLockMode.ReadOnly, srcImg.PixelFormat);

            int nextLayer = 3;
            for (int i = 0; i < 4; i++)
            {
                bool drawSprites = room.backgrounds.DrawNextLayer(region, dstData, srcData, ref nextLayer);
                if (drawSprites && main.ViewSprites)
                {
                    room.enemyList.DrawSprites(rect, dstData, room.spritesets[main.EnemySet], room.vramObj);
                }
            }

            srcImg.UnlockBits(srcData);

            ((Bitmap)this.BackgroundImage).UnlockBits(dstData);

            using (Graphics g = Graphics.FromImage(this.BackgroundImage))
            {
                if (main.OutlineSprites)
                {
                    room.enemyList.DrawOutlines(g, rect);
                }
                if (main.OutlineDoors)
                {
                    room.doorList.Draw(g, rect, true);
                }
                if (main.OutlineScrolls)
                {
                    room.scrollList.Draw(g, rect);
                }
                if (main.ViewValues)
                {
                    room.backgrounds.clipTypes.DrawValues(g, rect);
                }
                if (main.ViewBreakable)
                {
                    room.backgrounds.clipTypes.DrawBreakable(g, rect);
                }
                if (main.ViewCollision)
                {
                    room.backgrounds.clipTypes.DrawCollision(g, rect);
                }
                if (main.OutlineEffect)
                {
                    DrawEffectPosition(g, room.header.effectY);
                }
                if (main.OutlineScreens)
                {
                    DrawScreenOutlines(g, rect);
                }
            }

            rect.X <<= zoom;
            rect.Y <<= zoom;
            rect.Width <<= zoom;
            rect.Height <<= zoom;
            Invalidate(rect);
        }

        private void DrawEffectPosition(Graphics g, byte effectY)
        {
            Point p1 = new Point(0, effectY * 16);
            Point p2 = new Point(room.Width * 16, effectY * 16);
            g.DrawLine(mp, p1, p2);

            //Draw rectangle
            g.FillRectangle(mp.Brush, new Rectangle(p1.X + 4, p1.Y + 14, 8, 2));
            g.FillRectangle(mp.Brush, new Rectangle(p2.X - 16 + 4, p2.Y + 14, 8, 2));

            //Draw numbers
            Draw.DrawNumber(g, p1, effectY);
            Draw.DrawNumber(g, new Point(p2.X - 16, p2.Y), effectY);
        }

        private void DrawScreenOutlines(Graphics g, Rectangle rect)
        {
            int xEnd = rect.X + rect.Width;
            int yEnd = rect.Y + rect.Height;
            Pen sp = new Pen(Color.White, 2);

            int pos = ((rect.X + 192) / 240) * 240 + 32;
            while (pos <= xEnd)
            {
                g.DrawLine(sp, pos, rect.Y, pos, yEnd);
                pos += 240;
            }
            pos = ((rect.Y + 112) / 160) * 160 + 32;
            while (pos <= yEnd)
            {
                g.DrawLine(sp, rect.X, pos, xEnd, pos);
                pos += 160;
            }
        }

        public void OnErrorsChanged(RuleValidator? rv)
        {
            _errors = rv?.Errors;
            RebuildErrorRectangles();

            _pulseTimer.Enabled = _errorRects.Count > 0;
        }

        private void RebuildErrorRectangles()
        {
            _errorRects.Clear();
            if (_errors is null) return;

            foreach (var ((x, y), errList) in _errors)
            {
                if (errList.Count <= 0) continue;
                Rectangle r = new((x * 16) << zoom, (y * 16) << zoom, 16 << zoom, 16 << zoom);
                _errorRects.Add(r);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (room == null) { return; }

            if (redRect.X != -1)
            {
                pe.Graphics.DrawRectangle(rp, redRect);
            }
            if (selRect.X != -1 && selRect.IntersectsWith(pe.ClipRectangle))
            {
                pe.Graphics.DrawRectangle(bp, selRect);
                pe.Graphics.DrawRectangle(wp, selRect);
            }

            // Errors
            if (_errorRects.Count == 0) return;

            float wave = (MathF.Sin(_pulsePhase) + 1f) * 0.5f;
            int alpha = 10 + (int)(wave * 90);

            _pulseBrush.Color = Color.FromArgb(alpha, Color.Gold);

            bool highlightedStillThere = false;
            foreach (var rect in _errorRects)
            {
                if (rect.Location == HighlightedWarningRect.Location)
                {
                    highlightedStillThere = true;
                    continue;
                }
                if (!pe.ClipRectangle.IntersectsWith(rect)) continue;
                pe.Graphics.FillRectangle(_pulseBrush, rect);
            }

            if (!highlightedStillThere)
                HighlightedWarning = null;
            if (HighlightedWarning is null) return;

            wave = (MathF.Sin(_pulsePhase * 3) + 1f) * 0.5f;
            alpha = 20 + (int)(wave * 90);
            _pulseHighlightBrush.Color = Color.FromArgb(alpha, Color.Red);

            pe.Graphics.FillRectangle(_pulseHighlightBrush, HighlightedWarningRect);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            pevent.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            pevent.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            base.OnPaintBackground(pevent);
        }

        public event EventHandler<MouseEventArgs> Scrolled;

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            Scrolled.Invoke(this, e);
            base.OnMouseWheel(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!this.Focused) this.Focus();
        }
    }
}
