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
    class JpegGDIPlus : GDIImageSaver
    {
        public JpegGDIPlus(List<Shape> shapes) : base(shapes)
        {
            bit.Clear(Color.White);
            graphics = new GDIPlusCommonGraphics(bit, Color.Black, Color.White, true, 0, 2);
        }

        public override void Export()
        {
            base.Export();
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
            }
        }
    }
}
