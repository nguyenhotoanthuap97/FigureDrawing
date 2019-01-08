using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.Diagram.Flowchart
{
    class FCForwardBlock : ForwardBlock
    {
        private int x1, y1, x2, y2;

        public FCForwardBlock(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void draw(CommonGraphics g)
        {
            int cx1 = 0, cx2 = 0, cy1 = 0, cy2 = 0;
            g.DrawLine(x1, x2, y1, y2);
            if (x2 > x1) cx1 = cx2 = x2 - 10;
            if (x2 < x1) cx1 = cx2 = x2 + 10;
            if (x2 == x1) {
                cx1 = x2 - 10;
                cx2 = x2 + 10;
            }
            if (y2 > y1) cy1 = cy2 = y2 - 10;
            if (y2 < y1) cy1 = cy2 = y2 + 10;
            if (y2 == y1)
            {
                cy1 = y2 - 10;
                cy2 = y2 + 10;
            }
            g.DrawLine(x2, cx2, y2, cy2);
            g.DrawLine(x2, cx1, y2, cy1);
        }

        public override int getCornerX()
        {
            return x1;
        }

        public override int getCornerY()
        {
            return y1;
        }

        public override int getHeight()
        {
            return Math.Abs(y2 - y1);
        }

        public override int getWidth()
        {
            return Math.Abs(x2 - x1);
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
