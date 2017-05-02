using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Ex
{
    class Car
    {
        public GraphicsPath path1 = new GraphicsPath();

        public Car(int x, int y)
        {
            Point[] rec =
                 {
                new Point(x, y),
            new Point(x + 200, y),
            new Point(x + 200, y + 100),
            new Point(x, y + 100)
            };

            path1.AddPolygon(rec);
        }
    }
}
