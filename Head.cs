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
            rec.Y = Normalize.NormalizeY(0);
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
            rec.X += dx;
        }
    }
}
