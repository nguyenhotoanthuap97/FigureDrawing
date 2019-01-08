using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.Diagram.Flowchart
{
    class FCOutputBlock : OutputBlock
    {
        private int x, y, width, height;

        public FCOutputBlock(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.width = size;
            this.height = 70 * size / 150;
        }

        public override void draw(CommonGraphics g)
        {
            g.DrawLine(x, x + width, y, y);
            g.DrawLine(x + width, x + width, y, y + 50 * width / 150);
            g.DrawLine(x + width, x + 130 * width / 150, y + 50 * width / 150, y + height);
            g.DrawLine(x + 130 * width / 150, x, y + height, y + height);
            g.DrawLine(x, x, y + height, y);
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
