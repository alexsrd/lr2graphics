using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Runtime.InteropServices;

namespace lr2graphics
{
    public class Head : TransformsObj
    {
        Ear leftEar = new Ear(-1.7f,-1,-2.5f,4,4.8f,5.5f);
        Ear rightEar = new Ear(1.7f,1,2.5f,4,4.8f,5.5f);
        Eye leftEye = new Eye(-1.5f,4,-1.4f,3.8f);
        Eye rightEye = new Eye(0.5f, 4, 0.6f, 3.8f);
        Whisker whisker1 = new Whisker(new PointF(-1.25f,2.75f),new PointF(-2.8f,3f));
        Whisker whisker2 = new Whisker(new PointF(-1.25f, 2.25f), new PointF(-3f, 2.25f));
        Whisker whisker3 = new Whisker(new PointF(-1.25f, 1.5f), new PointF(-2.7f, 1.25f));
        Whisker whisker4 = new Whisker(new PointF(1.2f, 2.75f), new PointF(2.6f, 3f));
        Whisker whisker5 = new Whisker(new PointF(1.2f, 2.25f), new PointF(2.8f, 2.25f));
        Whisker whisker6 = new Whisker(new PointF(1.2f, 1.5f), new PointF(2.5f, 1.25f));
        Nose nose = new Nose(-0.5f,2.5f,15,10);

        public Head()
        {
            path.AddEllipse(Normalize.NormalizeX(-2), Normalize.NormalizeY(5), 70, 75);
        }

        public void DrawObj(Graphics e)
        {
            e.FillPath(Brushes.Orange, path);
            e.DrawPath(new Pen(Brushes.Gray,3), path);
            leftEar.DrawObj(e);
            rightEar.DrawObj(e);
            leftEye.DrawObj(e);
            rightEye.DrawObj(e);
            whisker1.DrawObj(e);
            whisker2.DrawObj(e);
            whisker3.DrawObj(e);
            whisker4.DrawObj(e);
            whisker5.DrawObj(e);
            whisker6.DrawObj(e);
            nose.DrawObj(e);
        }

        public void Translate(int dx,int dy)
        {
            if(CheckBodyPart.Head)     this.TranslateObj(dx, dy);
            if (CheckBodyPart.Ear1)    leftEar.TranslateObj(dx, dy);
            if (CheckBodyPart.Ear2)    rightEar.TranslateObj(dx, dy);
            if (CheckBodyPart.Eye1)    leftEye.Translate(dx, dy);
            if (CheckBodyPart.Eye2)    rightEye.Translate(dx, dy);
            if (CheckBodyPart.Whisker1) whisker1.TranslateObj(dx, dy);
            if (CheckBodyPart.Whisker2) whisker2.TranslateObj(dx, dy);
            if (CheckBodyPart.Whisker3) whisker3.TranslateObj(dx, dy);
            if (CheckBodyPart.Whisker4) whisker4.TranslateObj(dx, dy);
            if (CheckBodyPart.Whisker5) whisker5.TranslateObj(dx, dy);
            if (CheckBodyPart.Whisker6) whisker6.TranslateObj(dx, dy);
            if (CheckBodyPart.Nose)     nose.TranslateObj(dx, dy);
        }
        
        public void Rotate(int angle)
        {
            if(CheckBodyPart.Head)     this.RotateObj(angle);
            if (CheckBodyPart.Ear1)    leftEar.RotateObj(angle);
            if (CheckBodyPart.Ear2)    rightEar.RotateObj(angle);
            if (CheckBodyPart.Eye1)    leftEye.Rotate(angle);
            if (CheckBodyPart.Eye2)    rightEye.Rotate(angle);
            if (CheckBodyPart.Whisker1)whisker1.RotateObj(angle);
            if (CheckBodyPart.Whisker2)whisker2.RotateObj(angle);
            if (CheckBodyPart.Whisker3)whisker3.RotateObj(angle);
            if (CheckBodyPart.Whisker4)whisker4.RotateObj(angle);
            if (CheckBodyPart.Whisker5)whisker5.RotateObj(angle);
            if (CheckBodyPart.Whisker6)whisker6.RotateObj(angle);
            if (CheckBodyPart.Nose) nose.RotateObj(angle);
        }
        public void Scale(float x,float y)
        {
           if(CheckBodyPart.Head)     this.ScaleObj(x, y);
           if (CheckBodyPart.Ear1)    leftEar.ScaleObj(x, y);
           if (CheckBodyPart.Ear2)    rightEar.ScaleObj(x, y);
           if (CheckBodyPart.Eye1)    leftEye.Scale(x,y);
           if (CheckBodyPart.Eye2)    rightEye.Scale(x,y);
           if (CheckBodyPart.Whisker1)whisker1.ScaleObj(x, y);
           if (CheckBodyPart.Whisker2)whisker2.ScaleObj(x, y);
           if (CheckBodyPart.Whisker3)whisker3.ScaleObj(x, y);
           if (CheckBodyPart.Whisker4)whisker4.ScaleObj(x, y);
           if (CheckBodyPart.Whisker5)whisker5.ScaleObj(x, y);
           if (CheckBodyPart.Whisker6)whisker6.ScaleObj(x, y);
            if (CheckBodyPart.Nose) nose.ScaleObj(x,y);
        }
    }
}