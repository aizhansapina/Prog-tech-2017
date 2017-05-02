using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Asteroid
{
    class AstNstar
    {
        public GraphicsPath path5 = new GraphicsPath();
        public GraphicsPath path6 = new GraphicsPath();
        public GraphicsPath path7 = new GraphicsPath();

        public void stars(int x, int y)
        {
            path5.AddEllipse(x, y, 20, 20);
        }

        public void asteroid(int x, int y)
        {
            Point[] tdown =
                {
                new Point(x, y - 20),
                new Point(x + 20, y + 10),
                new Point(x - 20, y + 10)
            };
            Point[] tup =
                {
                new Point(x - 20, y - 10),
                new Point(x + 20, y - 10),
                new Point(x, y + 20)
            };

            path6.AddPolygon(tdown);
            path7.AddPolygon(tup);

            
        }
    }
}
