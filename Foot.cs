using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2graphics
{
    public class Foot : TransformsObj
    {
        public Foot(float x,float y)
        {
            path.AddEllipse(Normalize.NormalizeX(x), Normalize.NormalizeY(y), 20, 50);
            Matrix m = new Matrix();
            m.Rotate(0);
            path.Transform(m);
        }
        public void DrawObj(Graphics e)
        {
            e.FillPath(Brushes.Orange, path);
            e.DrawPath(new Pen(Brushes.Gray, 2), path);
        }
    }
}
