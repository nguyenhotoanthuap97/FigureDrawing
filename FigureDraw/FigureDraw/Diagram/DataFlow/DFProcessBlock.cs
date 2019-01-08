using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.Diagram.DataFlow
{
    class DFProcessBlock : ProcessBlock
    {
        private int x, y, size;

        public DFProcessBlock(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public override void draw(CommonGraphics g)
        {
            g.DrawEllipse(x, y, size, 70 * size / 100);
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
            return 70 * size / 100;
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
