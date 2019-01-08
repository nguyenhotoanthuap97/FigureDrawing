using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.Diagram.DataFlow
{
    class DFEndBlock : EndBlock
    {
        private int x, y, size;

        public DFEndBlock(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public override void draw(CommonGraphics g)
        {
            g.DrawEllipse(x, y, size, size * 70 / 100);
            g.DrawText(x + size * 37 / 100, y + size * 18 / 100, size / 5, "N");
        }

        public override int getCornerX()
        {
            return x;
        }

        public override int getCornerY()
        {
            return y;
        }

        public override int getHeight()
        {
            return size * 70 / 100;
        }

        public override int getWidth()
        {
            return size;
        }

        public override void shift(int distance)
        {
            x += distance;
            y += distance;
        }
    }
}
