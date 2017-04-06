using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Asteroid
{
    class Ship
    {
        public GraphicsPath path3 = new GraphicsPath();
        public GraphicsPath path4 = new GraphicsPath();

        public void ship(int x, int y)
        {
            Point[] p =
            {
                new Point(x, y - 45),
                new Point(x + 45, y - 20),
                new Point(x + 45, y + 20),
                new Point(x, y + 45),
                new Point(x - 45, y + 20),
                new Point(x - 45, y - 20)
            };

            path3.AddPolygon(p);
        }

        public void gun(int x, int y)
        {
            Point[] gun =
            {
                new Point(x - 10, y - 2),
                new Point(x, y - 18),
                new Point(x + 10, y - 2),
                new Point(x + 2, y - 2),
                new Point(x + 2, y + 18),
                new Point(x - 2, y + 18),
                new Point(x - 2, y - 2)
            };

            path4.AddPolygon(gun);
        }
    }
}
