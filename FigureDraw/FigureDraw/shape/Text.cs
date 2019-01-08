using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;

namespace FigureDraw.shape
{
    class Text : Shape
    {
        private int x;
        private int y;
        private int size;
        private string text;

        public Text(int x, int y, int size, string text)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            this.text = text;
        }

        public override void draw(CommonGraphics g)
        {
            g.DrawText(x, y, size, text);
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
            return size;
        }

        public override int getWidth()
        {
            return size * text.Length;
        }

        public override void shift(int distance)
        {
            this.x += distance;
            this.y += distance;
            this.size += 3;
        }
    }
}
