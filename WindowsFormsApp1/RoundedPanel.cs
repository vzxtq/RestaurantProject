using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 18;
        public Color BorderColor { get; set; } = Color.Gray;
        public int BorderThickness { get; set; } = 2;
        public Color PanelBackColor { get; set; } = Color.White;

        private Region _lastRegion;

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.Padding = new Padding(CornerRadius, CornerRadius, CornerRadius, CornerRadius);
            this.BackColor = Color.Transparent;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            UpdateRegion();
            Invalidate();
        }

        private void UpdateRegion()
        {
            using (var path = GetRoundedPath())
            {
                if (_lastRegion != null)
                    _lastRegion.Dispose();
                _lastRegion = new Region(path);
                this.Region = _lastRegion;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var path = GetRoundedPath())
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (var shadowBrush = new SolidBrush(Color.FromArgb(30, 0, 0, 0)))
                {
                    var shadowPath = GetRoundedPath(4, 4);
                    e.Graphics.FillPath(shadowBrush, shadowPath);
                }

                using (var brush = new SolidBrush(this.PanelBackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                using (var pen = new Pen(BorderColor, BorderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedPath(int offsetX = 0, int offsetY = 0)
        {
            int r = CornerRadius;
            int w = this.Width - 1 - offsetX;
            int h = this.Height - 1 - offsetY;
            var path = new GraphicsPath();
            path.AddArc(offsetX, offsetY, r, r, 180, 90);
            path.AddArc(w - r, offsetY, r, r, 270, 90);
            path.AddArc(w - r, h - r, r, r, 0, 90);
            path.AddArc(offsetX, h - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _lastRegion != null)
                _lastRegion.Dispose();
            base.Dispose(disposing);
        }
    }
}
