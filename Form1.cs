using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr2graphics
{
    public partial class Form1 : Form
    {
        int oldTranslateX = 0;
        int oldTranslateY = 0;
        float oldScaleX = 1;
        float oldScaleY = 1;
        int oldAngle = 0;

        Head head;
        Body body;
        public Form1()
        {
            InitializeComponent();
            Normalize.WinWidth = pictureBox.ClientSize.Width;
            Normalize.WinHeight = pictureBox.ClientSize.Height;
            head = new Head();
            body = new Body();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Normalize.WinWidth = pictureBox.ClientSize.Width;
            Normalize.WinHeight = pictureBox.ClientSize.Height;

            head.DrawObj(e.Graphics);
            body.DrawObj(e.Graphics);

            DrawXAxis(e.Graphics);
            DrawYAxis(e.Graphics);
            RelativePoint.Draw(e.Graphics);
        }
        //Рисование оси X
        private void DrawXAxis(Graphics e)
        {
            e.DrawLine(new Pen(Brushes.Black), 0, Normalize.WinHeight / 2, Normalize.WinWidth, Normalize.WinHeight / 2);
            for (int i = DecartCoord.xMin; i <= DecartCoord.xMax; i++)
            {
                e.DrawString(i.ToString(), new Font(Font.FontFamily, 6), Brushes.Blue, Convert.ToInt32(Normalize.NormalizeX(i)), Normalize.WinHeight / 2);
            }

        }
        //Рисование оси Y
        private void DrawYAxis(Graphics e)
        {
            e.DrawLine(new Pen(Brushes.Black), Normalize.WinWidth / 2, 0, Normalize.WinWidth / 2, Normalize.WinHeight);
            for (int i = DecartCoord.yMin; i <= DecartCoord.yMax; i++)
            {
                e.DrawString(i.ToString(), new Font(Font.FontFamily, 6), Brushes.Blue, Normalize.WinWidth / 2, Convert.ToInt32(Normalize.NormalizeY(i)));
            }
        }


        private void Translate_ValueChanged(object sender, EventArgs e)
        {
            int valueX = Convert.ToInt32(translateX.Value) - oldTranslateX;
            oldTranslateX = Convert.ToInt32(translateX.Value);
            int valueY = Convert.ToInt32(translateY.Value) - oldTranslateY;
            oldTranslateY = Convert.ToInt32(translateY.Value);
            head.Translate(valueX, valueY);
            body.Translate(valueX, valueY);
            pictureBox.Refresh();
        }


        private void Rotate_ValueChanged(object sender, EventArgs e)
        {
            int angle = Convert.ToInt32(Rotate.Value) - oldAngle;
            oldAngle = Convert.ToInt32(Rotate.Value);
            if (Rotate.Value == 360) Rotate.Value = 0;
            else if (Rotate.Value == -1) Rotate.Value = 359;
            head.Rotate(angle);
            body.Rotate(angle);
            pictureBox.Refresh();
        }

        private void Scale_ValueChanged(object sender, EventArgs e)
        {
            float x = float.Parse(ScaleX.Value.ToString()) / oldScaleX;
            oldScaleX = float.Parse(ScaleX.Value.ToString());
            float y = float.Parse(ScaleY.Value.ToString()) / oldScaleY;
            oldScaleY = float.Parse(ScaleY.Value.ToString());
            head.Scale(x, y);
            body.Scale(x, y);
            pictureBox.Refresh();
        }

        private void checkHead_CheckedChanged(object sender, EventArgs e)
        {
            CheckBodyPart.Head = checkHead.Checked;
            if (checkHead.Checked)
            {
                CheckBodyPart.Whisker1 = checkWhisker1.Checked = true;
                CheckBodyPart.Whisker2 = checkWhisker2.Checked = true;
                CheckBodyPart.Whisker3 = checkWhisker3.Checked = true;
                CheckBodyPart.Whisker4 = checkWhisker4.Checked = true;
                CheckBodyPart.Whisker5 = checkWhisker5.Checked = true;
                CheckBodyPart.Whisker6 = checkWhisker6.Checked = true;
                CheckBodyPart.Nose = checkNose.Checked = true;
                CheckBodyPart.Eye1 = checkEye1.Checked = true;
                CheckBodyPart.Eye2 = checkEye2.Checked = true;
                CheckBodyPart.Ear1 = checkEar1.Checked = true;
                CheckBodyPart.Ear2 = checkEar2.Checked = true;
            }
            else if (!checkHead.Checked)
            {
                CheckBodyPart.Whisker1 = checkWhisker1.Checked = false;
                CheckBodyPart.Whisker2 = checkWhisker2.Checked = false;
                CheckBodyPart.Whisker3 = checkWhisker3.Checked = false;
                CheckBodyPart.Whisker4 = checkWhisker4.Checked = false;
                CheckBodyPart.Whisker5 = checkWhisker5.Checked = false;
                CheckBodyPart.Whisker6 = checkWhisker6.Checked = false;
                CheckBodyPart.Nose = checkNose.Checked = false;
                CheckBodyPart.Eye1 = checkEye1.Checked = false;
                CheckBodyPart.Eye2 = checkEye2.Checked = false;
                CheckBodyPart.Ear1 = checkEar1.Checked = false;
                CheckBodyPart.Ear2 = checkEar2.Checked = false;
            }
        }

        private void CheckParts(object sender, EventArgs e)
        {
            CheckBodyPart.Whisker1 = checkWhisker1.Checked;
            CheckBodyPart.Whisker2 = checkWhisker2.Checked;
            CheckBodyPart.Whisker3 = checkWhisker3.Checked;
            CheckBodyPart.Whisker4 = checkWhisker4.Checked;
            CheckBodyPart.Whisker5 = checkWhisker5.Checked;
            CheckBodyPart.Whisker6 = checkWhisker6.Checked;
            CheckBodyPart.Nose = checkNose.Checked;
            CheckBodyPart.Eye1 = checkEye1.Checked;
            CheckBodyPart.Eye2 = checkEye2.Checked;
            CheckBodyPart.Ear1 = checkEar1.Checked;
            CheckBodyPart.Ear2 = checkEar2.Checked;
            CheckBodyPart.Foot1 = checkFoot1.Checked;
            CheckBodyPart.Foot2 = checkFoot2.Checked;
            CheckBodyPart.Tail = checkTail.Checked;
        }

        private void checkBody_CheckedChanged(object sender, EventArgs e)
        {
            CheckBodyPart.Body = checkBody.Checked;
            if(checkBody.Checked)
            {
                CheckBodyPart.Foot1 = checkFoot1.Checked = true;
                CheckBodyPart.Foot2 = checkFoot2.Checked = true;
                CheckBodyPart.Tail = checkTail.Checked = true;
            }
            else if (!checkBody.Checked)
            {
                CheckBodyPart.Foot1 = checkFoot1.Checked = false;
                CheckBodyPart.Foot2 = checkFoot2.Checked = false;
                CheckBodyPart.Tail = checkTail.Checked = false;
            }
        }
    }
}
