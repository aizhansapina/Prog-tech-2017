using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintS
{
    public enum Tool
    {
        None,
        Pen,
        Line,
        Rectangle,
        Ellipse,
        Triangle
    }

    class MyPaint
    {
        public Graphics g;
        public GraphicsPath path;
        public PictureBox picture;
        public Pen pen;
        public Bitmap bmp;
        public Point prev;
        public Tool tool;
        public Color fillColor;

        public MyPaint(PictureBox pictureBox1)
        {
            picture = pictureBox1;
            bmp = new Bitmap(picture.Width, picture.Height);
            picture.Image = bmp;
            pen = new Pen(Color.Black, 2);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            path = new GraphicsPath();
            tool = Tool.None;
            fillColor = Color.Black;
            picture.Paint += Picture_Paint;

        }

        private void Picture_Paint(object sender, PaintEventArgs e)
        {
            if (path != null)
            {
                e.Graphics.DrawPath(pen, path);
                bmp = (Bitmap)picture.Image;
            }
        }

        public void SaveLastPath()
        {
            if (path != null)
            {
                g.DrawPath(pen, path);
                bmp = (Bitmap)picture.Image;
            }
        }

        public void Draw(Point cur)
        {
            switch (tool)
            {
                case Tool.Pen:
                    g.DrawLine(pen, prev, cur);
                    g.FillEllipse(new SolidBrush(pen.Color), cur.X - pen.Width / 2, cur.Y - pen.Width / 2, pen.Width, pen.Width);
                    prev = cur;
                    break;
                case Tool.Line:
                    path.Reset();
                    path.AddLine(prev, cur);
                    break;
                case Tool.Rectangle:
                    path.Reset();
                    Rectangle r = new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y);
                    path.AddRectangle(r);
                    break;
                case Tool.Ellipse:
                    path.Reset();
                    r = new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y);
                    path.AddEllipse(r);
                    break;
            }
            picture.Refresh();
        }

        public void SaveImage(string filename)
        {
            bmp.Save(filename);
        }
    }
}
