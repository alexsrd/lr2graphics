using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2graphics
{
    public class Pupil : TransformsObj
    {
        public Pupil(float x,float y)
        {
            path.AddEllipse(Normalize.NormalizeX(x), Normalize.NormalizeY(y), 7, 7);
        }
        public void DrawObj(Graphics e)
        {
            e.FillPath(Brushes.Black, path);
        }
    }
}
