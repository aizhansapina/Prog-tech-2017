using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Paint
{
    public partial class Form1 : Form
    {
        MyPaint paint = new MyPaint();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint.mouseClicked = true;
            paint.prevPoint = e.Location;        
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint.mouseClicked)
                paint.Draw(pictureBox1.CreateGraphics(), e.Location, e);
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint.mouseClicked = false;

            int w = Math.Abs(paint.prevPoint.X - e.Location.X);
            int h = Math.Abs(paint.prevPoint.Y - e.Location.Y);
            int minX = Math.Min(paint.prevPoint.X, e.Location.X);
            int minY = Math.Min(paint.prevPoint.Y, e.Location.Y);

            /*if (shape == Shape.RECTANGLE)
                g.DrawRectangle(pen, minX, minY, w, h);
            else if (shape == Shape.ELLIPSE)
                g.DrawEllipse(pen, minX, minY, w, h);*/

            pictureBox1.Refresh();

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            paint.pen.Width = trackBar1.Value;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                paint.pen.Color = colorDialog1.Color;
                paint.brush.Color = colorDialog1.Color;
            }
        }

    }
}
