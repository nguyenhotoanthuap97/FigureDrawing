 using FigureDraw.Diagram.DataFlow;
using FigureDraw.Diagram.Flowchart;
using FigureDraw.Effect;
using FigureDraw.graphics;
using FigureDraw.Graphics.ImageSaver;
using FigureDraw.shape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    public partial class MainForm : Form
    {

        System.Drawing.Graphics gGDI = null;
        System.Drawing.Graphics gCairo = null;
        System.Drawing.Graphics gEffectCairo = null;
        System.Drawing.Graphics gEffectGDI = null;
        CommonGraphics gdiPlus = null;
        CommonGraphics cairo = null;
        CommonGraphics gr = null;
        CommonGraphics effect = null;
        Shape shape = null;
        List<Shape> shapes = new List<Shape>();
        ImageSaver saver = null;
        public MainForm()
        {
            InitializeComponent();
            shapeCBB.SelectedIndex = 0;
            libCBB.SelectedIndex = 0;
            gGDI = this.CreateGraphics();
            gCairo = this.CreateGraphics();
            gEffectCairo = this.CreateGraphics();
            gEffectGDI = this.CreateGraphics();
            shapeCBB.DropDownStyle = ComboBoxStyle.DropDownList;
            libCBB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void showLine()
        {
            aLa.Text = "x1";
            bLa.Text = "y1";
            cLa.Text = "x2";
            dLa.Text = "y2";
        }
        private void showRect()
        {
            aLa.Text = "x";
            bLa.Text = "y";
            cLa.Text = "Width";
            dLa.Text = "Height";
        }

        private void showEllipse()
        {
            aLa.Text = "cx";
            bLa.Text = "cy";
            cLa.Text = "H radius";
            dLa.Text = "V radius";
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(aTxtBox.Text);
            int b = Int32.Parse(bTxtBox.Text);
            int c = Int32.Parse(cTxtBox.Text);
            int d = Int32.Parse(dTxtBox.Text);

            switch (shapeCBB.SelectedIndex)
            {
                case 0:
                    shape = new Line(a, b, c, d);
                    break;
                case 1:
                    shape = new shape.Rectangle(a, b, c, d);
                    break;
                case 2:
                    shape = new Ellipse(a, b, c, d);
                    break;
            }

            if (libCBB.SelectedIndex == 0)
            {
                if (gdiPlus == null)
                    gdiPlus = new GDIPlusCommonGraphics(gGDI, Color.Black, Color.White, false, 255, 2);
                shape.draw(gdiPlus);
            }
            else
            {
                if (cairo == null)
                    cairo = new CairoCommonGraphics(gCairo, Color.Black, Color.White, true, 255, 2);
                shape.draw(cairo);
            }

            shapes.Add(shape);

        }

        private void changeShape(object sender, EventArgs e)
        {
            switch (shapeCBB.SelectedIndex)
            {
                case 0:
                    showLine();
                    break;
                case 1:
                    showRect();
                    break;
                case 2:
                    showEllipse();
                    break;
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            saver = new PngGdiPlus(shapes);
            //saver = new JpegGDIPlus(shapes);
            saver.Export();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

            if (effect == null)
            {
                effect = new GDIPlusCommonGraphics(gEffectGDI, Color.Gray, Color.Gray, true, 255, 1);
            }

            if (gr == null)
            {
                gr = new GDIPlusCommonGraphics(gGDI, Color.Black, Color.White, true, 255, 2);
            }
            Shape sh1 = new shape.Ellipse(10, 10, 100, 60);
            Shape sh2 = new shape.Ellipse(10, 100, 100, 60);
            Shape sh1WithShadow = new ShadowEffect(sh1, effect);
            Shape sh2WithShadow = new ShadowEffect(sh2, effect);
            Shape sh2WithShadowAndBorder = new BorderEffect(sh2WithShadow, effect);

            Shape DFstartBlock = new DFStartBlock(150, 5, 100);
            Shape DFforward1 = new DFForwardBlock(200, 76, 200, 100);
            Shape DFinput = new DFInputBlock(150, 100, 100);
            Shape DFforward2 = new DFForwardBlock(200, 146, 200, 170);
            Shape DFprocess = new DFProcessBlock(150, 170, 100);
            Shape DFforward3 = new DFForwardBlock(200, 236, 200, 260);
            Shape DFoutput = new DFOutputBlock(150, 260, 100);
            Shape DFforward4 = new DFForwardBlock(200, 306, 200, 330);
            Shape DFendBlock = new DFEndBlock(150, 330, 100);
            sh1WithShadow.draw(gr);
            sh2WithShadowAndBorder.draw(gr);

            Shape FCstart = new FCStartBlock(280, 20, 100);
            Shape FCforward1 = new FCForwardBlock(330, 68, 330, 100);
            Shape FCinput = new FCInputBlock(280, 100, 100);
            Shape FCforward2 = new FCForwardBlock(330, 146, 330, 170);
            Shape FCprocess = new FCProcessBlock(280, 170, 100);
            Shape FCforward3 = new FCForwardBlock(330, 215, 330, 260);
            Shape FCoutput = new FCOutputBlock(280, 260, 100);
            Shape FCforward4 = new FCForwardBlock(330, 306, 330, 330);
            Shape FCcondition = new FCConditionBlock(280, 330, 100);
            Shape FCforward5 = new FCForwardBlock(330, 376, 330, 400);
            Shape FCend = new FCEndBlock(280, 400, 100);

            DFstartBlock.draw(gr);
            DFforward1.draw(gr);
            DFinput.draw(gr);
            DFforward2.draw(gr);
            DFprocess.draw(gr);
            DFforward3.draw(gr);
            DFoutput.draw(gr);
            DFforward4.draw(gr);
            DFendBlock.draw(gr);

            FCstart.draw(gr);
            FCforward1.draw(gr);
            FCinput.draw(gr);
            FCforward2.draw(gr);
            FCprocess.draw(gr);
            FCforward3.draw(gr);
            FCoutput.draw(gr);
            FCforward4.draw(gr);
            FCcondition.draw(gr);
            FCforward5.draw(gr);
            FCend.draw(gr);

            shapes.Add(sh1WithShadow);
            shapes.Add(sh2WithShadowAndBorder);
            shapes.Add(DFstartBlock);
            shapes.Add(DFinput);
            shapes.Add(DFprocess);
            shapes.Add(DFoutput);
            shapes.Add(DFendBlock);
            shapes.Add(DFforward1);
            shapes.Add(DFforward2);
            shapes.Add(DFforward3);
            shapes.Add(DFforward4);
            shapes.Add(FCstart);
            shapes.Add(FCinput);
            shapes.Add(FCoutput);
            shapes.Add(FCprocess);
            shapes.Add(FCcondition);
            shapes.Add(FCend);
            shapes.Add(FCforward1);
            shapes.Add(FCforward2);
            shapes.Add(FCforward3);
            shapes.Add(FCforward4);
            shapes.Add(FCforward5);
        }
    }
}
