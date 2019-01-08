using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.shape
{
    class Ellipse : Shape
    {
        private int cx;
        private int cy;
        private int hradius;
        private int vradius;

        public Ellipse(int cx, int cy, int hradius, int vradius)
        {
            this.cx = cx;
            this.cy = cy;
            this.hradius = hradius;
            this.vradius = vradius;
        }

        public override void draw(CommonGraphics g)
        {
            g.DrawEllipse(cx, cy, hradius, vradius);
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
            return hradius;
        }

        public override int getWidth()
        {
            return vradius;
        }

        public override void shift(int distance)
        {
            this.cx += distance;
            this.cy += distance;
            this.hradius += 3;
            this.vradius += 3;
        }
    }
}
