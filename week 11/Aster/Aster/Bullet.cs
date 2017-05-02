using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Aster
{
    public class Bullet
    {
        public Point location;
        public SolidBrush sbr;
        public Graphics g;

        public Bullet(Graphics _g, Point p)
        {
            location = new Point();
            g = _g;
            sbr = new SolidBrush(Color.Green);
            location = p;
        }

        public void Draw()
        {
            g.FillEllipse(sbr, location.X - 5, location.Y - 13, 10, 26);
            g.FillEllipse(sbr, location.X - 13, location.Y - 5, 26, 10);
        }
    }
}
