using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.Diagram.Flowchart
{
    class FCProcessBlock : ProcessBlock
    {
        private int x, y, width, height;
        public FCProcessBlock(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.width = size;
            this.height = 70 * size / 150;
        }
        public override void draw(CommonGraphics g)
        {
            g.DrawRect(x, y, width, height);
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
            return height;
        }

        public override int getWidth()
        {
            return width;
        }

        public override void shift(int distance)
        {
            x += distance;
            y += distance;
        }
    }
}
