using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TaskMana
{
    class CircularPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();

            // Create a circle the size of the panel
            path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);

            // Apply the circular shape to the panel
            this.Region = new Region(path);

            // Optional: Draw border
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}
