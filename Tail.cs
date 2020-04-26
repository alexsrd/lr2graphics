using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2graphics
{
    public class Tail : TransformsObj
    {
        public Tail()
        {
            PointF[] points = new PointF[]
            {
                new PointF(Normalize.NormalizeX(-2.1f),Normalize.NormalizeY(-4.6f)),
                new PointF(Normalize.NormalizeX(-4),Normalize.NormalizeY(-4.6f)),
                new PointF(Normalize.NormalizeX(-4),Normalize.NormalizeY(-5f)),
                new PointF(Normalize.NormalizeX(-2.1f),Normalize.NormalizeY(-5f))
            };
            path.AddPolygon(points);
        }
        public void DrawObj(Graphics e)
        {
            e.FillPath(Brushes.Orange, path);
            e.DrawPath(new Pen(Brushes.Gray, 2), path);
        }
        
    }
}
