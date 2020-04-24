using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2graphics
{
    public static class Normalize
    {
        public static int WinHeight;
        public static int WinWidth;
        public static int NormalizeX(double x)
        {
            return Convert.ToInt32((x - DecartCoord.xMin) * WinWidth / (DecartCoord.xMax - DecartCoord.xMin));
        }
        public static int NormalizeY(double y)
        {
            return Convert.ToInt32(WinHeight - (y - DecartCoord.yMin) * WinHeight / (DecartCoord.yMax - DecartCoord.yMin));
        }

        
    }
}
