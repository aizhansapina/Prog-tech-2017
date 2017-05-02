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

namespace Paint1
{
    public partial class Form1 : Form
    {
        enum Shape
        {
            LINE,
            RECTANGLE,
            ELLIPSE,
            NONE
        };

        Shape shape = Shape.LINE;
        SolidBrush brush = new SolidBrush(Color.Black);
        Bitmap bmp;
        Graphics g;
        bool mouseClicked = false;
        Point prevPoint = new Point(0, 0);
        Pen pen = new Pen(Color.Black);
        Graphics gPic;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            gPic = pictureBox1.CreateGraphics();
            pictureBox1.Image = bmp;
        }

        public void Draw(Graphics g, Point curPoint, EventArgs e)
        {
            if (shape == Shape.LINE)
            {
                g.DrawLine(pen, prevPoint, curPoint);
                prevPoint = curPoint;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            prevPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
            int w = Math.Abs(prevPoint.X - e.Location.X);
            int h = Math.Abs(prevPoint.Y - e.Location.Y);
            int minX = Math.Min(prevPoint.X, e.Location.X);
            int minY = Math.Min(prevPoint.Y, e.Location.Y);

            if (shape == Shape.RECTANGLE)
                g.DrawRectangle(pen, minX, minY, w, h);
            else if (shape == Shape.ELLIPSE)
                g.DrawEllipse(pen, minX, minY, w, h);

            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                if (shape == Shape.LINE)
                {
                    g.DrawLine(pen, prevPoint.X, prevPoint.Y, e.Location.X, e.Location.Y);
                    prevPoint = e.Location;
                }
                else
                {
                    if (shape == Shape.RECTANGLE)
                    {
                        int w = Math.Abs(prevPoint.X - e.Location.X);
                        int h = Math.Abs(prevPoint.Y - e.Location.Y);
                        int minX = Math.Min(prevPoint.X, e.Location.X);
                        int minY = Math.Min(prevPoint.Y, e.Location.Y);

                        g.DrawRectangle(pen, minX, minY, w, h);
                    }

                    else
                    {
                        if (shape == Shape.ELLIPSE)
                        {
                            int w = Math.Abs(prevPoint.X - e.Location.X);
                            int h = Math.Abs(prevPoint.Y - e.Location.Y);
                            int minX = Math.Min(prevPoint.X, e.Location.X);
                            int minY = Math.Min(prevPoint.Y, e.Location.Y);

                            g.DrawEllipse(pen, minX, minY, w, h);
                        }
                    }
                }
                //pictureBox1.Refresh();
            }
            //pictureBox1.Refresh();
        }

      
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shape = Shape.LINE;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shape = Shape.RECTANGLE;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shape = Shape.ELLIPSE;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                brush.Color = colorDialog1.Color;
            }
        }
    }
}
    

