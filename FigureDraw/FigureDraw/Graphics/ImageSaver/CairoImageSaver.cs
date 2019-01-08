using Cairo;
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
    class CairoImageSaver : ImageSaver
    {
        protected Bitmap img = new Bitmap(800, 440, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        protected System.Drawing.Imaging.BitmapData bit = null;
        protected Cairo.ImageSurface imgsf = null;
        protected Context ct = null;
        protected List<Shape> shapes = null;
        protected CommonGraphics g = null;

        public CairoImageSaver(List<Shape> s)
        {
            bit = img.LockBits(new System.Drawing.Rectangle(0, 0, 800, 440), System.Drawing.Imaging.ImageLockMode.WriteOnly, img.PixelFormat);
            imgsf = new Cairo.ImageSurface(bit.Scan0, Cairo.Format.Argb32, 800, 440, 800 * 4);
            ct = new Context(imgsf);
            shapes = s;
            g = new CairoCommonGraphics(ct);
        }

        public override void Export()
        {
            for (int i = 0; i < this.shapes.Count; i++)
            {
                this.shapes[i].draw(g);
            }
        }
    }
}
