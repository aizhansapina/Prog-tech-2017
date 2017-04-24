using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int motion = 2;
        int cnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//New Game
        {
            
            motion = 2;
            cnt = 0;

            A01.Enabled = true;
            A02.Enabled = true;
            A03.Enabled = true;
            A11.Enabled = true;
            A12.Enabled = true;
            A13.Enabled = true;
            A21.Enabled = true;
            A22.Enabled = true;
            A23.Enabled = true;

            A01.Text = "";
            A11.Text = "";
            A21.Text = "";
            A02.Text = "";
            A12.Text = "";
            A22.Text = "";
            A03.Text = "";
            A13.Text = "";
            A23.Text = "";

            o.Text = "0";
            x.Text = "0";
            drawn.Text = "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)//Exit
        {
            Application.Exit();
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

            if (button.Text != null)
                button.Enabled = false;

            cnt++;
            IsWinner();
        }

        private void IsWinner()
        {
            bool winner = false;

            //horizontal
            if (A01.Text == A02.Text && A02.Text == A03.Text && !A01.Enabled)
                winner = true;
            else if (A11.Text == A12.Text && A12.Text == A13.Text && !A11.Enabled)
                winner = true;
            else if (A21.Text == A22.Text && A22.Text == A23.Text && !A21.Enabled)
                winner = true;

            //vertical
            else if (A01.Text == A11.Text && A11.Text == A21.Text && !A01.Enabled)
                winner = true;
            else if (A02.Text == A12.Text && A12.Text == A22.Text && !A02.Enabled)
                winner = true;
            else if (A03.Text == A13.Text && A13.Text == A23.Text && !A03.Enabled)
                winner = true;

            //diagonal
            else if (A01.Text == A12.Text && A12.Text == A23.Text && !A01.Enabled)
                winner = true;
            else if (A03.Text == A12.Text && A12.Text == A21.Text && !A03.Enabled)
                winner = true;

            if (winner)
            {
                A01.Enabled = false;
                A02.Enabled = false;
                A03.Enabled = false;
                A11.Enabled = false;
                A12.Enabled = false;
                A13.Enabled = false;
                A21.Enabled = false;
                A22.Enabled = false;
                A23.Enabled = false;

                string Winner = "";

                if (motion % 2 != 0)
                {
                    Winner = "X";
                    x.Text = (Int32.Parse(x.Text) + 1).ToString();
                }

                else
                {
                    Winner = "O";
                    o.Text = (Int32.Parse(o.Text) + 1).ToString();
                }

                MessageBox.Show(Winner + " " + "IS WINNER!", "GAME OVER", MessageBoxButtons.OK);
            }

            else
            {
                if (cnt == 9)
                {
                    MessageBox.Show("DRAWN!", "GAME OVER", MessageBoxButtons.OK);
                    drawn.Text = (Int32.Parse(drawn.Text) + 1).ToString();
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)//About
        {
            MessageBox.Show("Made By Aizhan Sapina", "About");
        }

        private void mouse_enter(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Enabled)
            {
                if (motion % 2 == 0)
                    button.Text = "X";
                else
                    button.Text = "O";
            }
        }

        private void mouse_leave(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Enabled)
            {
                button.Text = "";
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)//PLay Again
        {
            
            motion = 2;
            cnt = 0;


            A01.Enabled = true;
            A02.Enabled = true;
            A03.Enabled = true;
            A11.Enabled = true;
            A12.Enabled = true;
            A13.Enabled = true;
            A21.Enabled = true;
            A22.Enabled = true;
            A23.Enabled = true;

            A01.Text = "";
            A11.Text = "";
            A21.Text = "";
            A02.Text = "";
            A12.Text = "";
            A22.Text = "";
            A03.Text = "";
            A13.Text = "";
            A23.Text = "";
        }
    }
}
