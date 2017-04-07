using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Ship s = new Ship();
        Bullet b = new Bullet();
        AstNstar ans = new AstNstar();
        
        
        SolidBrush brush1;
        SolidBrush brush2;
        SolidBrush brush3;
        SolidBrush brush4;

        public Form1()
        {

            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp = new Bitmap(@"C:\Users\Айжан\Desktop\PT 2017\week 11\Asteroid\Asteroid\bin\Debug\blue.jpg");
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            brush1 = new SolidBrush(Color.Red);
            brush2 = new SolidBrush(Color.White);
            brush3 = new SolidBrush(Color.Yellow);
            brush4 = new SolidBrush(Color.Green);

            b.bullet(280, 110);
            s.ship(240, 162);
            s.gun(240, 162);
            ans.stars(310, 70);
            ans.stars(440, 130);
            ans.stars(390, 200);
            ans.stars(440, 295);
            ans.stars(160, 240);
            ans.stars(160, 40);
            ans.stars(40, 270);
            ans.stars(35, 70);
            ans.asteroid(90, 100);
            ans.asteroid(110, 230);
            ans.asteroid(330, 270);
            ans.asteroid(370, 120);





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           //g.DrawPath(new Pen(Color.Green), b.path1);
            g.FillPath(brush4, b.path1);
            g.FillPath(brush4, b.path2);
            g.FillPath(brush3, s.path3);
            g.FillPath(brush4, s.path4);
            g.FillPath(brush2, ans.path5);
            g.FillPath(brush1, ans.path6);
            g.FillPath(brush1, ans.path7);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(label1.Text == null)
            label1.Text = "Level:" + "Score:" + "Live";
        }
    }
}
