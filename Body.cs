using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2graphics
{
    public class Body : TransformsObj
    {
        Tail tail = new Tail();
        Foot leftFoot = new Foot(0, -1.8f);
        Foot rightFoot = new Foot(-1.3f, -1.8f);
        public Body()
        {
            PointF[] points = new PointF[]
            {
                new PointF(Normalize.NormalizeX(1.1f),Normalize.NormalizeY(0.2f)),
                new PointF(Normalize.NormalizeX(-1.3f),Normalize.NormalizeY(0.2f)),
                new PointF(Normalize.NormalizeX(-2.2f),Normalize.NormalizeY(-5)),
                new PointF(Normalize.NormalizeX(1.9f),Normalize.NormalizeY(-5))
            };
            path.AddPolygon(points);
        }
        public void DrawObj(Graphics e)
        {
            tail.DrawObj(e);
            e.FillPath(Brushes.Red, path);
            e.DrawPath(new Pen(Brushes.Gray, 2), path);
            leftFoot.DrawObj(e);
            rightFoot.DrawObj(e);
        }

        public void Translate(int dx, int dy)
        {
            if (CheckBodyPart.Body) this.TranslateObj(dx, dy);
            if (CheckBodyPart.Tail) tail.TranslateObj(dx, dy);
            if (CheckBodyPart.Foot1) leftFoot.TranslateObj(dx, dy);
            if (CheckBodyPart.Foot2) rightFoot.TranslateObj(dx, dy);
        }
        public void Rotate(int angle)
        {
            if (CheckBodyPart.Body) this.RotateObj(angle);
            if (CheckBodyPart.Tail) tail.RotateObj(angle);
            if (CheckBodyPart.Foot1) leftFoot.RotateObj(angle);
            if (CheckBodyPart.Foot2) rightFoot.RotateObj(angle);
        }
        public void Scale(float x, float y)
        {
            if (CheckBodyPart.Body) this.ScaleObj(x, y);
            if (CheckBodyPart.Tail) tail.ScaleObj(x, y);
            if (CheckBodyPart.Foot1) leftFoot.ScaleObj(x, y);
            if (CheckBodyPart.Foot2) rightFoot.ScaleObj(x, y);
        }
    }
}
