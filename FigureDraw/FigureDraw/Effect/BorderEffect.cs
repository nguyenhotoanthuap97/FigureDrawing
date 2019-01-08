using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.graphics;
using FigureDraw.shape;

namespace FigureDraw.Effect
{
    class BorderEffect : EffectBlock
    {
        public BorderEffect(Shape s, CommonGraphics g)
        {
            base.shape = s;
            base.e = g;
        }

        public override void draw(CommonGraphics g)
        {
            shape.draw(g);
            new Rectangle(shape.getCornerX() - 5, shape.getCornerY() - 5, 10, 10).draw(e);
            new Ellipse(shape.getCornerX() + shape.getHeight() / 2 - 5, shape.getCornerY() + shape.getWidth() - 5, 10, 10).draw(e);
            new Rectangle(shape.getCornerX() + shape.getHeight() - 5, shape.getCornerY() - 5, 10, 10).draw(e);
            new Rectangle(shape.getCornerX() - 5, shape.getCornerY() + shape.getWidth() - 5, 10, 10).draw(e);
            new Rectangle(shape.getCornerX() + shape.getHeight() - 5, shape.getCornerY() + shape.getWidth() - 5, 10, 10).draw(e);
            new Ellipse(shape.getCornerX() + shape.getHeight() / 2 - 5, shape.getCornerY() - 5, 10, 10).draw(e);
            new Ellipse(shape.getCornerX() + shape.getHeight() - 5, shape.getCornerY() + shape.getWidth() / 2 - 5, 10, 10).draw(e);
            new Ellipse(shape.getCornerX() - 5, shape.getCornerY() + shape.getWidth() / 2 - 5, 10, 10).draw(e);
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
