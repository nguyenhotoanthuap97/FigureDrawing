using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;
using FigureDraw.shape;
using System.Drawing;

namespace FigureDraw.Effect
{
    class ShadowEffect : EffectBlock
    {
        public ShadowEffect(Shape shape, CommonGraphics effect)
        {
            base.shape = shape;
            base.e = effect;
        }

        public override void draw(CommonGraphics g)
        {
            shape.draw(e);
            shape.shift(-10);
            shape.draw(g);
        }

        public override int getCornerX()
        {
            return shape.getCornerX();
        }

        public override int getCornerY()
        {
            return shape.getCornerY();
        }

        public override int getHeight()
        {
            return shape.getHeight();
        }

        public override int getWidth()
        {
            return shape.getWidth();
        }

        public override void shift(int distance)
        {
        }
    }
}
