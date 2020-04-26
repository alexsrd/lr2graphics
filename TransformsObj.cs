using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2graphics
{
    public class TransformsObj
    {
        public GraphicsPath path = new GraphicsPath();

        public void TranslateObj(int dx, int dy)
        {
            PointF[] points = path.PathPoints;

            PointF p1 = new PointF(Normalize.DenormalizeX(points[0].X), Normalize.DenormalizeY(points[0].Y));
            PointF p2 = new PointF(p1.X + dx, p1.Y + dy);
            p1.X = Normalize.NormalizeX(p2.X) - Normalize.NormalizeX(p1.X);
            p1.Y = Normalize.NormalizeY(p2.Y) - Normalize.NormalizeY(p1.Y);

            Matrix m = new Matrix();
            m.Translate(p1.X, p1.Y);
            path.Transform(m);
        }

        public void RotateObj(int angle)
        {
            Matrix m = new Matrix();
            m.RotateAt(angle, new PointF(RelativePoint.CenterX, RelativePoint.CenterY));
            path.Transform(m);
        }

        public void ScaleObj(float x, float y)
        {
            Matrix m = new Matrix();
            m.Translate(-RelativePoint.CenterX, -RelativePoint.CenterY);
            path.Transform(m);
            m.Reset();
            m.Scale(x, y);
            path.Transform(m);
            m.Reset();
            m.Translate(RelativePoint.CenterX, RelativePoint.CenterY);
            path.Transform(m);
        }
    }
}
