using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Asteroid
{
    class Bullet
    {
        public GraphicsPath path1 = new GraphicsPath();
        public GraphicsPath path2 = new GraphicsPath();
    

        public void bullet(int x, int y)
        {
            path1.AddEllipse(x - 3, y - 10, 8, 22);
            path2.AddEllipse(x - 10, y - 3, 22, 8);
        }
    }
}
