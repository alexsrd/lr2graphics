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
        Head head;
        public Form1()
        {
            InitializeComponent();
            Normalize.WinWidth = pictureBox.ClientSize.Width;
            Normalize.WinHeight = pictureBox.ClientSize.Height;
            head = new Head();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Normalize.WinWidth = pictureBox.ClientSize.Width;
            Normalize.WinHeight = pictureBox.ClientSize.Height;
            head.Draw(e.Graphics);
            DrawXAxis(e.Graphics);
            DrawYAxis(e.Graphics);
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(numericUpDown1.Value) - oldTranslateX;
            oldTranslateX = Convert.ToInt32(numericUpDown1.Value);
            head.Translate(value,0);
            pictureBox.Refresh();
        }
    }
}
