using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lr2graphics
{
    public class Nose : TransformsObj
    {
        public Nose(float x,float y,float w,float h )
        {
            path.AddEllipse(Normalize.NormalizeX(x),Normalize.NormalizeY(y),w,h);
        }
        public void DrawObj(Graphics e)
        {
            e.FillPath(Brushes.Pink, path);
            e.DrawPath(new Pen(Brushes.Gray, 2), path);
        }
    }
}
