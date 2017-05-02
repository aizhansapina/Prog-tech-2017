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


namespace End3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 100;
        int y = 100;
        SolidBrush b2 = new SolidBrush(Color.Red);
        SolidBrush b1 = new SolidBrush(Color.Yellow);
        SolidBrush b3 = new SolidBrush(Color.Green);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(b2, x + 30, y + 70, 50, 50);
            e.Graphics.FillEllipse(b1, x + 120, y + 70, 50, 50);
            e.Graphics.FillEllipse(b3, x + 200, y + 70, 50, 50);

        }
    }
}
