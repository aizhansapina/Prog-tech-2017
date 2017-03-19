using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serialization
{
    class Program
    {
        [Serializable]
        class Complex
        {
            public int x, y;
            public Complex(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public Complex() { }

            static int gcd(int x, int y)
            {
                if (x == 0)
                    return y;
                return gcd(y % x, x);
            }

            public override string ToString()
            {
                return this.x / gcd(this.x, this.y) + "/" + this.y / gcd(this.x, this.y);
            }

            public static Complex operator +(Complex a, Complex b)
            {
                Complex c = new Complex(a.x * b.y + b.x * a.y, a.y * b.y);
                return c;
            }

            public static Complex operator -(Complex a, Complex b)
            {
                Complex c = new Complex(a.x * b.y - b.x * a.y, a.y * b.y);
                return c;
            }

            public static Complex operator *(Complex a, Complex b)
            {
                Complex c = new Complex(a.x * b.x, a.y * b.y);
                return c;
            }

            public static Complex operator /(Complex a, Complex b)
            {
                Complex c = new Complex(a.x * b.y, b.x * a.y);
                return c;
            }

        }

        public static void xml()
        {
            Complex a = new Complex(2, 5);
            Complex b = new Complex(3, 4);
            //Complex[] complex = new Complex[] { a, b };
            Complex sum = a + b;

            using (FileStream fs = new FileStream("ser.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite)) 
            {
                XmlSerializer xs = new XmlSerializer(typeof(Complex));
                xs.Serialize(fs, sum);//complex);
                fs.Close();

                Console.WriteLine("Object serialized");
            }

            using (FileStream fs = new FileStream("ser.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Complex));
                Complex summ = (Complex)xs.Deserialize(fs) as Complex;
                fs.Close();

                Console.WriteLine(sum);
            }
        }

        public static void bf()
        {
            //Complex a = new Complex(2, 5);
            //Complex b = new Complex(3, 4);
            //Complex[] complex = new Complex[] { a, b };
            //Complex sum = a + b;
            string s = Console.ReadLine();
            string[] p = s.Split();
            //int d = int.Parse(p[0]);
            //int c = int.Parse(p[1]);
            //int = d + c;
            Complex a = new Complex();

            foreach (string d in p)
            {
                string[] v = d.Split('/');
                Complex b = new Complex(int.Parse(v[0]), int.Parse(v[1]));
            }

            //Console.WriteLine(b);

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("ser.bf", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                bf.Serialize(fs, a);
                fs.Close();

                Console.WriteLine("Object serialized");
            }
        }
            
            public static void bfdes()
            {
                using (FileStream fs = new FileStream("ser.bf", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                string s = Console.ReadLine();
                string[] p = s.Split();
                //int d = int.Parse(p[0]);
                //int c = int.Parse(p[1]);
                //int t = d + c;
                Complex a = new Complex();

                foreach (string d in p)
                {
                    string[] v = d.Split('/');
                    Complex b = new Complex(int.Parse(v[0]), int.Parse(v[1]));
                }

                BinaryFormatter bf = new BinaryFormatter();
                
                Complex c = (Complex)bf.Deserialize(fs);
                fs.Close();

                Console.WriteLine(a);
                }

            Console.ReadKey();
            }
        static void Main(string[] args)
        {
            //xml();
            //bf();
            bfdes();
        }

        }

    }
