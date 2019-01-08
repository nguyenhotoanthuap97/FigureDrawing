using FigureDraw.graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.shape
{
    abstract class Shape
    {
        public abstract void shift(int distance);
        public abstract void draw(CommonGraphics g);
        public abstract int getCornerX();
        public abstract int getCornerY();
        public abstract int getWidth();
        public abstract int getHeight();
    }
}
