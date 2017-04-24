using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calculate calculator = new Calculate();

        double memory = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void number_click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Clear();

            Button button = sender as Button;

            if (display.Text == ",")
                display.Text = "0,";

            if (button.Text == ",")
            {
                if (!display.Text.Contains(","))
                    display.Text += button.Text;
            }
            else
                display.Text += button.Text;
        }

        public void operation_click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (calculator.FirstNumber != 0)
            {
                equal.PerformClick();
                calculator.operation = button.Text;

                if (calculator.result != 0)
                {
                    calculator.FirstNumber = calculator.result;
                }

                equation.Text = calculator.result + " " + calculator.operation;
                display.Text = "";

            }

            else
            {
                calculator.FirstNumber = double.Parse(display.Text);
                calculator.operation = button.Text;
                display.Text = "";
                equation.Text = calculator.FirstNumber + " " + calculator.operation;
            }

        }

        public void result_click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            calculator.SecondNumber = double.Parse(display.Text);
            calculator.Calcul();

            display.Text = calculator.result.ToString();
            equation.Text = "";
        }

        /* if (display.Text != null)
         {
             if (calculator.SecondNumber == null)
             {
                 calculator.FirstNumber = double.Parse(display.Text);
                 calculator.SecondNumber = calculator.FirstNumber;
                 calculator.Calcul();
                 display.Text = calculator.result.ToString();
                 equation.Text = "";
             }
            else
             {
                 calculator.SecondNumber = double.Parse(display.Text);
                 calculator.Calcul();
                 display.Text = calculator.result.ToString();
                 equation.Text = "";
             }
         }
     }*/


        private void erase_click(object sender, EventArgs e)
        {
            int lngth = display.Text.Length - 1;
            string text = display.Text;
            display.Clear();

            if (display.Text == null)
                display.Text = "0";

            for (int i = 0; i < lngth; i++)
            {
                display.Text = display.Text + text[i];   
            }

            if (display.Text == "")
                display.Text = "0";
        }

        public void c_click(object sender, EventArgs e)
        {
            display.Clear();
            calculator.FirstNumber = 0;
            calculator.SecondNumber = 0;
            calculator.result = 0;
            calculator.operation = "";
            memory = 0;
            display.Text = "0";
            equation.Text = "";
            //display.Tag = "";
        }

        public void ce_click(object sender, EventArgs e)
        {
            display.Text = "";
            display.Text = "0";
            calculator.SecondNumber = 0;
        }


        public void button26_Click(object sender, EventArgs e)
        {

        }

        public void sqrt_click(object sender, EventArgs e)
        {
            try
            {
                if (display.Text != null)
                {
                    if (double.Parse(display.Text) > 0)
                        display.Text = Math.Sqrt(double.Parse(display.Text)).ToString();
                    else
                        MessageBox.Show("Incorrect data", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception)
            {
                //MessageBox.Show("Incorrect data", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void sqr_click(object sender, EventArgs e)
        {
            if (display.Text != null)
                display.Text = Math.Pow(double.Parse(display.Text), 2).ToString();
        }

        public void dbyone_click(object sender, EventArgs e)
        {
            if (display.Text != null)
            {
                if (double.Parse(display.Text) != 0)
                    display.Text = (1 / (double.Parse(display.Text))).ToString();
                else
                    MessageBox.Show("Incorrect data", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void percent_click(object sender, EventArgs e)
        {
            if (display.Text != null)
            {
                if (calculator.operation == null)
                {
                    calculator.FirstNumber = double.Parse(display.Text);
                    calculator.FirstNumber = calculator.FirstNumber / 100;
                    display.Text = calculator.FirstNumber.ToString();
                }
                else
                {
                    calculator.SecondNumber = double.Parse(display.Text);
                    calculator.result = calculator.FirstNumber * calculator.SecondNumber / 100;
                    display.Text = calculator.result.ToString();
                }
            }
        }

        public void plusminus_click(object sender, EventArgs e)
        {
            try
            {
                if (display.Text != null)
                    display.Text = (double.Parse(display.Text) * (-1)).ToString();
            }

            catch (Exception)
            {

            }
        }

        public void m_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string ButtonText = button.Text;

            if (ButtonText == "MC")
            {
                memory = 0;
                equation.Text = "";
            }

            if (ButtonText == "MR")
            {
                display.Text = memory.ToString();
            }

            if (ButtonText == "MS")
            {
                memory = double.Parse(display.Text);
                equation.Text = "M";
                display.Text = "";
            }

            if (ButtonText == "M+")
            {
                memory = memory + double.Parse(display.Text);
            }

            if (ButtonText == "M-")
            {
                memory = memory - double.Parse(display.Text);
            }
        }
    }
}
