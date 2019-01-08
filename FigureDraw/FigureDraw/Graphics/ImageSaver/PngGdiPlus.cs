using FigureDraw.graphics;
using FigureDraw.shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw.Graphics.ImageSaver
{
    class PngGdiPlus : GDIImageSaver
    {
        public PngGdiPlus(List<Shape> shapes) : base(shapes)
        {
        }

        public override void Export()
        {
            base.Export();
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                bmp.Save(dialog.FileName + ".png", ImageFormat.Png);
            }
        }
    }
}
