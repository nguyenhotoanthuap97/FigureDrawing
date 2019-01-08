using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.Diagram.DataFlow
{
    class DFInputBlock : InputBlock
    {
        private int x, y, size;

        public DFInputBlock(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public override void draw(CommonGraphics g)
        {
            g.DrawRect(x, y, size, size * 70 / 150);
            g.DrawLine(x + size * 20 / 150, x + size * 20 / 150, y, y + 70 * size / 150);
            g.DrawLine(x + 130 * size / 150, x + 130 * size / 150, y, y + 70 * size / 150);
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
            return size * 70 / 150;
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
