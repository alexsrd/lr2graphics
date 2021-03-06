﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2graphics
{
    class Whisker : TransformsObj
    {
        public Whisker(PointF p1,PointF p2)
        {
            p1 = Normalize.NormalizePoint(p1);
            p2 = Normalize.NormalizePoint(p2);
            path.AddLine(p1,p2);
        }
        public void DrawObj(Graphics e)
        {
            e.FillPath(Brushes.Black, path);
            e.DrawPath(new Pen(Brushes.Black,2), path);
        }
    }
}
