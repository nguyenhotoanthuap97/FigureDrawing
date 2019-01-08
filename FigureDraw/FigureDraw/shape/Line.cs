using FigureDraw.graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.shape
{
    class Line : Shape
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public Line(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public override void draw(CommonGraphics g)
        {
            g.DrawLine(x1, y1, x2, y2);
        }

        public override int getCornerX()
        {
            return x1;
        }

        public override int getCornerY()
        {
            return x2;
        }

        public override int getHeight()
        {
            return Math.Abs(x1 - y1);
        }

        public override int getWidth()
        {
            return Math.Abs(x2 - y2);
        }

        public override void shift(int distance)
        {
            x1 += distance;
            x2 += distance;
            y1 += distance;
            y2 += distance;
        }
    }
}
