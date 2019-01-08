using FigureDraw.graphics;
using FigureDraw.shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Effect
{
    abstract class EffectBlock : Shape
    {
        protected Shape shape;
        protected CommonGraphics e = null;
    }
}
