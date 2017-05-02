using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace End1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Black;
               /* button.Bottom. = Color.Black;
                button.Top. = Color.Black;
                button.Left. = Color.Black;
                button.Right. = Color.Black;*/


            }
            else
            {
                button.BackColor = Color.White;
               /* button.Bottom. = Color.Black;
                button.Top. = Color.Black;
                button.Left. = Color.Black;
                button.Right. = Color.Black;*/
            }
                
            /*if ( A1.BackColor == Color.White)
            {
                A1.BackColor = Color.Black;
                A2.BackColor = Color.Black;
                B1.BackColor = Color.Black;
            }
            else
            {
                A1.BackColor = Color.White;
                A2.BackColor = Color.White;
                B1.BackColor = Color.White;
            }
            if (A2.BackColor == Color.White)
            {
                A1.BackColor = Color.Black;
                B2.BackColor = Color.Black;
                A3.BackColor = Color.Black;
            }
            else
            {
                A1.BackColor = Color.White;
                B2.BackColor = Color.White;
                A3.BackColor = Color.White;
            }
            if (A3.BackColor == Color.White)
            {
                A2.BackColor = Color.Black;
                B3.BackColor = Color.Black;
                A4.BackColor = Color.Black;
            }
            else
            {
                A2.BackColor = Color.White;
                B3.BackColor = Color.White;
                A4.BackColor = Color.White;
            }
            if (A4.BackColor == Color.White)
            {
                A3.BackColor = Color.Black;
                B4.BackColor = Color.Black;
                
            }
            else
            {
                A3.BackColor = Color.White;
                B4.BackColor = Color.White;
            }
            if (B1.BackColor == Color.White)
            {
                A1.BackColor = Color.Black;
                B2.BackColor = Color.Black;
                C1.BackColor = Color.Black;
            }
            else
            {
                A1.BackColor = Color.White;
                B2.BackColor = Color.White;
                C1.BackColor = Color.White;
            }
            if (B2.BackColor == Color.White)
            {
                A2.BackColor = Color.Black;
                B1.BackColor = Color.Black;
                B3.BackColor = Color.Black;
                C2.BackColor = Color.Black;
            }
            else
            {
                B1.BackColor = Color.White;
                A2.BackColor = Color.White;
                B3.BackColor = Color.White;
                C2.BackColor = Color.White;
            }*/
        }
    }
}
