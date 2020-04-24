using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using Rectangle = System.Drawing.Rectangle;

namespace lr2graphics
{
    public class Head
    {
        public Rectangle rec = new Rectangle();
        public Head()
        {
            rec.X = Normalize.NormalizeX(0);
            rec.Y = Normalize.NormalizeY(-1);
            
            rec.Width = 10;
            rec.Height = 10;
        }

        public void Draw(Graphics e)
        {
            e.FillEllipse(Brushes.Red, rec);
            e.DrawEllipse(new Pen(Brushes.Red), rec);
        }

        public void Translate(int dx,int dy)
        {
            
            Point p1 = new Point(Normalize.DenormalizeX(rec.X), Normalize.DenormalizeY(rec.Y));
            Point p2 = new Point(p1.X + dx,p1.Y+dy);
            p1.X = Normalize.NormalizeX(p2.X) - Normalize.NormalizeX(p1.X);
            p1.Y = Normalize.NormalizeY(p2.Y) - Normalize.NormalizeX(p1.Y);
            rec.X += p1.X;
            
            if(dy != 0)
            {
                rec.Y += p2.Y;
            }
        }
    }
}
