using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FirstApp
{
    internal class RoundedImage : PictureBox
    {
        // Radius for the rounded corners
        private int _cornerRadius = 20;

        // Property to set the corner radius
        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = value;
                this.Invalidate(); // Redraw the control when radius changes
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Create a new GraphicsPath
            GraphicsPath gpath = new GraphicsPath();

            // Define the rounded rectangle
            gpath.AddArc(0, 0, _cornerRadius * 2, _cornerRadius * 2, 180, 90); // Top-left corner
            gpath.AddArc(this.Width - _cornerRadius * 2, 0, _cornerRadius * 2, _cornerRadius * 2, 270, 90); // Top-right corner
            gpath.AddArc(this.Width - _cornerRadius * 2, this.Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 0, 90); // Bottom-right corner
            gpath.AddArc(0, this.Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 90, 90); // Bottom-left corner
            gpath.CloseFigure();

            // Set the clipping region to the rounded rectangle
            pe.Graphics.SetClip(gpath);

            // Draw the base PictureBox image
            base.OnPaint(pe);

            // Reset clipping region
            pe.Graphics.ResetClip();

            // Draw a border if desired
            using (Pen pen = new Pen(Color.Gray, 2))
            {
                pe.Graphics.DrawPath(pen, gpath);
            }
        }
    }
}
