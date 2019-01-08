using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.Diagram.Flowchart
{
    class FCConditionBlock : ConditionBlock
    {
        private int x, y, width, height;

        public FCConditionBlock(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.width = size;
            this.height = size * 70 / 150;
        }

        public override void draw(CommonGraphics g)
        {
            g.DrawLine(x + width / 2, x + width, y, y + height / 2);
            g.DrawLine(x + width, x + width/2, y + height/2, y + height);
            g.DrawLine(x + width/2, x, y + height, y + height/2);
            g.DrawLine(x, x + width/2, y + height/2, y);
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
