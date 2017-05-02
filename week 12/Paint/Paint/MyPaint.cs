using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{

    class MyPaint
    {
        public enum Shape
        {
            LINE,
            RECTANGLE,
            ELLIPSE,
            FREE
        }

        public Shape shape;
        public bool mouseClicked;
        public Pen pen;
        public SolidBrush brush;
        public Point prevPoint;

        public MyPaint()
        {
            shape = Shape.LINE;
            mouseClicked = false;
            pen = new Pen(Color.Black);
            brush = new SolidBrush(Color.Black);
        }

        public void setPenColor(Color color)
        {
            pen.Color = color;
        }

        public void Draw(Graphics g, Point curPoint, EventArgs e)
        {
            if (shape == Shape.LINE)
            {
                g.DrawLine(pen, prevPoint, curPoint);
                prevPoint = curPoint;
            }

           /* if (shape == Shape.RECTANGLE)
            {
                int w = Math.Abs(prevPoint.X - e.Location.X);
                int h = Math.Abs(prevPoint.Y - e.Location.Y);
                int minX = Math.Min(prevPoint.X, e.Location.X);
                int minY = Math.Min(prevPoint.Y, e.Location.Y);
                g.DrawRectangle(pen, minX, minY, w, h);
            }*/

            
        }

    }
}
