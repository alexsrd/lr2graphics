using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lr2graphics
{
    public static class Normalize
    {
        public static float WinHeight;
        public static float WinWidth;
        public static float NormalizeX(float x)
        {
            return (x - DecartCoord.xMin) * WinWidth / (DecartCoord.xMax - DecartCoord.xMin);
        }
        public static float NormalizeY(float y)
        {
            return WinHeight - (y - DecartCoord.yMin) * WinHeight / (DecartCoord.yMax - DecartCoord.yMin);
        }

        public static float DenormalizeX(float x)
        {
            return x * (DecartCoord.xMax - DecartCoord.xMin) / WinWidth + DecartCoord.xMin;
        }

        public static float DenormalizeY(float y)
        {
            return DecartCoord.yMin - (y - WinHeight) * (DecartCoord.yMax - DecartCoord.yMin)/WinHeight;
        }
        public static PointF NormalizePoint(PointF p)
        {
            PointF result = new PointF();
            result.X = (p.X - DecartCoord.xMin) * WinWidth / (DecartCoord.xMax - DecartCoord.xMin);
            result.Y = WinHeight - (p.Y - DecartCoord.yMin) * WinHeight / (DecartCoord.yMax - DecartCoord.yMin);
            return result;
        }
    }
}
