using FigureDraw.graphics;
using FigureDraw.shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Graphics.ImageSaver
{
    class GDIImageSaver : ImageSaver
    {
        protected Bitmap bmp;
        protected System.Drawing.Graphics bit;
        protected List<Shape> shapes;
        protected CommonGraphics graphics = null;
        public GDIImageSaver(List<Shape> shapes)
        {
            bmp = new Bitmap(800, 440);
            bit = System.Drawing.Graphics.FromImage(bmp);
            this.shapes = shapes;
            graphics = new GDIPlusCommonGraphics(bit, Color.Black, Color.White, false, 255, 2);
        }

        public override void Export()
        {
            for (int i = 0; i < this.shapes.Count; i++)
            {
                this.shapes[i].draw(graphics);
            }
        }

    }
}
