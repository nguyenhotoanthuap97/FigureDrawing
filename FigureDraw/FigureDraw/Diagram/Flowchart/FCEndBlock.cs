using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.Diagram.Flowchart
{
    class FCEndBlock : EndBlock
    {
        private int cx, cy, hradius, vradius;

        public FCEndBlock(int cx, int cy, int size)
        {
            this.cx = cx;
            this.cy = cy;
            this.hradius = size;
            this.vradius = 70 * size / 150;
        }

        public override void draw(CommonGraphics g)
        {
            g.DrawEllipse(cx, cy, hradius, vradius);
            g.DrawText(cx + 55 * hradius / 150, cy + 22 * hradius / 150, 15 * hradius / 150, "End");
        }

        public override int getCornerX()
        {
            return cx;
        }

        public override int getCornerY()
        {
            return cy;
        }

        public override int getHeight()
        {
            return vradius;
        }

        public override int getWidth()
        {
            return hradius;
        }

        public override void shift(int distance)
        {
            cx += distance;
            cy += distance;
        }
    }
}
