using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintS
{
    public partial class Form1 : Form
    {
        MyPaint paint;

        public Form1()
        {
            InitializeComponent();
            paint = new MyPaint(pictureBox1);
            numericUpDown1.Value = (decimal)paint.pen.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paint.tool = Tool.Pen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paint.tool = Tool.Line;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            paint.tool = Tool.Triangle;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            paint.tool = Tool.Rectangle;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            paint.tool = Tool.Ellipse;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG file|*.jpg|PNG files|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                paint.SaveImage(saveFileDialog1.FileName);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                paint.bmp = (Bitmap)pictureBox1.Image;
                paint.picture = pictureBox1;
                paint.picture.Image = paint.bmp;
                paint.g = Graphics.FromImage(paint.bmp);
                paint.path.Reset();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint.prev = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                paint.Draw(e.Location);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint.SaveLastPath();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                paint.pen.Color = colorDialog1.Color;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            paint.pen.Width = (float)numericUpDown1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paint.pen = new Pen(Color.White, 2);
        }
    }
}
