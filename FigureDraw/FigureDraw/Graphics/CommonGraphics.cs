using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.graphics
{
    abstract class CommonGraphics
    {
        protected Color line = Color.Black;
        protected Color fill = Color.White;
        protected int trans = 0;
        protected int lineWidth = 2;
        protected bool isFilled = false;
        public abstract void DrawLine(int x1, int y1, int x2, int y2);
        public abstract void DrawRect(int x, int y, int width, int height);
        public abstract void DrawEllipse(int cx, int cy, int hradius, int vradius);
        public abstract void DrawText(int x, int y, int size, string text);
    }
}
