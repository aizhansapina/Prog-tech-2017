using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        class Complex
        {
            public int x;
            public int y;

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
                Complex c = new Complex(a.x * b.x + a.y * b.y, a.y * b.y);
                return c;
            }

            public static Complex operator -(Complex a, Complex b)
            {
                Complex c = new Complex(a.x * b.x - a.y * b.y, a.y * b.y);
                return c;
            }

            public static Complex operator *(Complex a, Complex b)
            {
                Complex c = new Complex(a.x * b.x * a.y * b.y, a.y * b.y);
                return c;
            }

            public static Complex operator /(Complex a, Complex b)
            {
                Complex c = new Complex(a.x * b.x / a.y * b.y, a.y * b.y);
                return c;
            }

        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ar = s.Split();

            Complex sum = new Complex(0, 0);
            foreach (string f in ar)
            {
                string[] arr = f.Split('/');
                Complex p = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));

                if (sum.x == 0 && sum.y == 0)
                    sum = p;
                else
                    sum = sum + p;
            }

            Complex sub = new Complex(0, 0);
            foreach (string f in ar)
            {
                string[] arr = f.Split('/');
                Complex p = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));

                if (sub.x == 0 && sub.y == 0)
                    sub = p;
                else
                    sub = sub - p;
            }

            Complex mult = new Complex(0, 0);
            foreach (string f in ar)
            {
                string[] arr = f.Split('/');
                Complex p = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));

                if (mult.x == 0 && mult.y == 0)
                    mult = p;
                else
                    mult = mult * p;
            }

            Complex div = new Complex(0, 0);
            foreach (string f in ar)
            {
                string[] arr = f.Split('/');
                Complex p = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));

                if (div.x == 0 && div.y == 0)
                    div = p;
                else
                    div = div / p;
            }

            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Sub : " + sub);
            Console.WriteLine("Mult : " + mult);
            Console.WriteLine("Div : " + div);

            Console.ReadKey();
        }
    }
}
