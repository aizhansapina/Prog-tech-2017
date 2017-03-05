using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_ex
{
    
    class Complex
    {
         
        int a, b;
        
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        
        public static Complex operator +(Complex w, Complex e)
        {
            Complex r = new Complex(w.a + e.a, w.b + e.b);
            return r;
        }
        
        public override string ToString()
        {
            return  this.a + "/" + this.b;
        }
    }
    class Program
    {
        static void Main()
        {
            Complex q = new Complex(4, 5);
            Complex z = new Complex(2, 3);
            Complex s = q + z;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
