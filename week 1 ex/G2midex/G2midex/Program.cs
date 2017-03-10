using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2midex
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    Console.WriteLine(i + " ");
            }
            Console.ReadKey();
        }
    }
}
