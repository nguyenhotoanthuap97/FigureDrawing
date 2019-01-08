using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.Diagram.Flowchart
{
    class FCInputBlock : InputBlock
    {
        private int x, y, width, height;

        public FCInputBlock(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.width = size;
            this.height = 70 * size / 150;
        }

        public override void draw(CommonGraphics g)
        {
            g.DrawLine(x, x + width, y, y);
            g.DrawLine(x + width, x + width - 20 * width / 150, y, y + height);
            g.DrawLine(x + width - 20 * width / 150, x - 20 * width / 150, y + height, y + height);
            g.DrawLine(x - 20 * width / 150, x, y + height, y);
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
