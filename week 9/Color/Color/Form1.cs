using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.textBox1.ForeColor = System.Drawing.Color.Red;
        }

        public void button2_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.textBox1.ForeColor = System.Drawing.Color.Green;
        }

        public void button3_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
        }
    }
}
