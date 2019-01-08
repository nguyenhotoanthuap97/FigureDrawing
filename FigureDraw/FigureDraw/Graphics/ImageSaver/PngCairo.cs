using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigureDraw.shape;

namespace FigureDraw.Graphics.ImageSaver
{
    class PngCairo : CairoImageSaver
    {
        public PngCairo(List<Shape> s) : base(s)
        {
        }

        public override void Export()
        {
            base.Export();
            base.img.UnlockBits(base.bit); 
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgsf.WriteToPng(dialog.FileName + ".png");
            }
        }
    }
}
