using Cairo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.graphics
{
    class CairoCommonGraphics : CommonGraphics
    {
        private Win32Surface surface = null;
        private Context ct = null;
        public CairoCommonGraphics(System.Drawing.Graphics g, System.Drawing.Color l, System.Drawing.Color f, bool i, int t, int w)
        {
            IntPtr hdc = g.GetHdc();
            surface = new Win32Surface(hdc);
            ct = new Context(surface);
            line = l;
            fill = f;
            isFilled = i;
            trans = t;
            lineWidth = w;
            ct.LineWidth = lineWidth;
        }

        public CairoCommonGraphics(Context ct)
        {
            this.ct = ct;
        }

        public override void DrawEllipse(int cx, int cy, int hradius, int vradius)
        {
            ct.Save();
            Matrix matrix = ct.Matrix;
            ct.Translate((double)cx + (double)hradius / 2, (double)cy + (double)vradius / 2);
            ct.Scale((double)hradius / 2, (double)vradius / 2);
            ct.SetSourceRGBA(line.R, line.G, line.B, trans);
            ct.NewPath();
            ct.Arc(0, 0, 1, 0, 2 * Math.PI);
            ct.Matrix = matrix;
            if (isFilled)
            {
                ct.SetSourceRGB(fill.R, fill.G, fill.B);
                ct.Fill();
            }
            ct.Stroke();
            ct.Restore();
        }

        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            ct.Save();
            ct.SetSourceRGBA(line.R, line.G, line.B, trans);
            ct.MoveTo(new PointD(x1, x2));
            ct.LineTo(new PointD(y1, y2));
            ct.Stroke();
            ct.Restore();
        }

        public override void DrawRect(int x, int y, int width, int height)
        {
            ct.Save();
            ct.SetSourceRGBA(line.R, line.G, line.B,trans);
            ct.Rectangle(new Cairo.Rectangle(x, y, width, height));
            ct.Stroke();
            if (isFilled)
            {
                ct.SetSourceRGB(fill.R, fill.G, fill.B);
                ct.Rectangle(new Cairo.Rectangle(x + 2, y + 2, width - 4, height - 4));
                ct.Fill();
            }
            else
                ct.Stroke();
            ct.Restore();
        }

        public override void DrawText(int x, int y, int size, string text)
        {
            ct.Save();
            ct.MoveTo(new PointD(x, y));
            ct.SetSourceRGBA(line.R, line.G, line.B, trans);
            ct.SelectFontFace("ariel", FontSlant.Normal, FontWeight.Normal);
            ct.SetFontSize(size);
            ct.ShowText(text);
            ct.Restore();
        }
    }
}
