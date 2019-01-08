using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.shape
{
    class Rectangle : Shape
    {
        private int x;
        private int y;
        private int width;
        private int height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
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
            return width;
        }

        public override int getWidth()
        {
            return height;
        }

        public override void shift(int distance)
        {
            x += distance;
            y += distance;
            width += 3;
            height += 3;
        }
    }
}
