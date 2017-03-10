using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        class Complex
        {
            public int x, y;
            public Complex(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
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
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(3, 4);

            Complex sum = a + b;
            Complex sub = a - b;
            Complex mult = a * b;
            Complex div = a / b;
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Sub : " + sub);
            Console.WriteLine("Mult : " + mult);
            Console.WriteLine("Div : " + div);

            Console.ReadKey();
        }
    }
}
