using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;
using FigureDraw.shape;

namespace FigureDraw.Effect
{
    class HighlightEffect : EffectBlock
    {
        public HighlightEffect(Shape s, CommonGraphics effect)
        {
            base.shape = s;
            base.e = effect;
        }

        public override void draw(CommonGraphics g)
        {
            shape.draw(g);
            shape.draw(e);
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
