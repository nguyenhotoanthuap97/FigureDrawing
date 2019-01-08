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
    class JpegCairo : CairoImageSaver
    {
        public JpegCairo(List<Shape> s) : base(s)
        {
            ct.SetSourceRGB(1, 1, 1);
            ct.Rectangle(new Cairo.Rectangle(0, 0, 800, 500));
            ct.Fill();
            ct.SetSourceRGB(0, 0, 0);
        }

        public override void Export()
        {
            base.Export();
            base.img.UnlockBits(base.bit);
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                base.img.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
            }
        }
    }
}
