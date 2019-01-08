using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.graphics
{
    class GDIPlusCommonGraphics : CommonGraphics
    {
        private System.Drawing.Graphics g = null;
        public GDIPlusCommonGraphics(System.Drawing.Graphics g, Color l, Color f, bool i, int t, int w)
        {
            this.g = g;
            line = l;
            fill = f;
            isFilled = i;
            trans = t;
            lineWidth = w;
        }
        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            Pen myPen = new Pen(Color.FromArgb(trans, line.R, line.G, line.B), lineWidth);
            g.DrawLine(myPen, x1, x2, y1, y2);
        }
        public override void DrawRect(int x, int y, int width, int height)
        {
            Pen myPen = new Pen(Color.FromArgb(trans, line.R, line.G, line.B), lineWidth);
            g.DrawRectangle(myPen, x, y, width, height);
            if (isFilled)
                g.FillRectangle(new SolidBrush(fill), new Rectangle(x + lineWidth, y + lineWidth, width - lineWidth - lineWidth /2, height - lineWidth - lineWidth/2));
        }
        public override void DrawEllipse(int cx, int cy, int hradius, int vradius)
        {
            Pen myPen = new Pen(Color.FromArgb(trans, line.R, line.G, line.B), lineWidth);
            g.DrawEllipse(myPen, cx, cy, hradius, vradius);
            if (isFilled)
                g.FillEllipse(new SolidBrush(fill), new Rectangle(cx + lineWidth, cy + lineWidth, hradius - lineWidth - lineWidth / 2 , vradius - lineWidth - lineWidth/2));
        }

        public override void DrawText(int x, int y, int size, string text)
        {
            SolidBrush drawBrush = new SolidBrush(line);
            PointF drawPoint = new PointF(x, y);
            g.DrawString(text, new Font("Ariel", size), drawBrush, drawPoint);
        }
    }
}
