using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace lr2graphics
{
    public class Ear : TransformsObj
    {

        public Ear(float x1,float x2,float x3,float y1,float y2,float y3)
        {
            PointF[] p = new PointF[]
            {
                new PointF(Normalize.NormalizeX(x1),Normalize.NormalizeY(y1)),
                new PointF(Normalize.NormalizeX(x2),Normalize.NormalizeY(y2)),
                new PointF(Normalize.NormalizeX(x3),Normalize.NormalizeY(y3))

            };
            path.AddPolygon(p);
        }

        public  void DrawObj(Graphics e)
        {
            e.FillPath(Brushes.OrangeRed, path);
            e.DrawPath(new Pen(Brushes.Gray,3),path);
        }
        
    }
}
