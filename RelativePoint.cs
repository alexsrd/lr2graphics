using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace lr2graphics
{
    public static class RelativePoint
    {
        static RectangleF rec = new RectangleF();
        public static float CenterX = Normalize.NormalizeX(2);
        public static float CenterY = Normalize.NormalizeY(1);

        public static void Draw(Graphics e)
        {
            rec.X = CenterX;
            rec.Y = CenterY;
            rec.Width = 5;
            rec.Height = 5;
            e.FillEllipse(Brushes.Black ,rec);
            e.DrawEllipse(new Pen(Brushes.Black),rec);
        }
    }
}
