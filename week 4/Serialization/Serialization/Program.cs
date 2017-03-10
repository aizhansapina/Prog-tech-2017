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
                Complex sum1 = (Complex)xs.Deserialize(fs);
                fs.Close();

                Console.WriteLine(sum);
            }
        }

        public static void bf()
        {
            Complex a = new Complex(2, 5);
            Complex b = new Complex(3, 4);
            //Complex[] complex = new Complex[] { a, b };
            Complex sum = a + b;

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("ser.bf", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                bf.Serialize(fs, sum);
                fs.Close();

                Console.WriteLine("Object serialized");
            }

            using (FileStream fs = new FileStream("ser.bf", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                Complex sum1 = (Complex)bf.Deserialize(fs);
                fs.Close();

                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            xml();
            //bf();

        }
    }
}
