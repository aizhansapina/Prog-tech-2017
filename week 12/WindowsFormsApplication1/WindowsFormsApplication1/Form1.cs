using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int motion = 2;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (motion % 2 == 0)
            {
                button.Text = "X";
                motion++;
            }

            else
            {
                button.Text = "O";
                motion++;
            }

            count++;

            if (button.Text != null)
                button.Enabled = false;
        }
    }
}
