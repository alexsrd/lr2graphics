using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2graphics
{
    public class Eye : TransformsObj
    {
        Pupil pupil;
        public Eye(float x,float y,float x1,float y1)
        {
            path.AddEllipse(Normalize.NormalizeX(x), Normalize.NormalizeY(y), 15,10);
            pupil = new Pupil(x1, y1);
        }

        public void DrawObj(Graphics e)
        {
            e.FillPath(Brushes.Green, path);
            e.DrawPath(new Pen(Brushes.Gray, 2), path);
            pupil.DrawObj(e);
        }
        public void Translate(int dx,int dy)
        {
            this.TranslateObj(dx, dy);
            pupil.TranslateObj(dx, dy);
        }
        public void Rotate(int angle)
        {
            this.RotateObj(angle);
            pupil.RotateObj(angle);
        }
        public void Scale(float x,float y)
        {
            this.ScaleObj(x, y);
            pupil.ScaleObj(x, y);
        }
        

    }
}
