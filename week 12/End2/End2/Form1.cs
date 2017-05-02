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

namespace End2
{
    public partial class Form1 : Form
    {
        int x = 100;
        int y = 100;
        bool clicked = false;
        
        Graphics g;
        SolidBrush b1 = new SolidBrush(Color.Black);
        SolidBrush b2 = new SolidBrush(Color.Black);

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            /*GraphicsPath path = new GraphicsPath();
            path.Reset();
            Rectangle r = new Rectangle(x , y , w , h);
            path.AddRectangle(r);
            
                
            path.Reset();
            r = new Rectangle(x , y , w, h);
            path.AddEllipse(r);*/
            
        }

        private void Paint_Click(object sender, PaintEventArgs e)
        {

            if (clicked)
            {
                e.Graphics.FillEllipse(b2, x + 30, y + 70, 50, 50);
                //e.Graphics.FillRectangle(b1, x + 120, y + 70, 50, 50);
            }
           
        }

        private void mouse_click(object sender, MouseEventArgs e)
        {
            clicked = true;
            Gra
        }
    }
}
