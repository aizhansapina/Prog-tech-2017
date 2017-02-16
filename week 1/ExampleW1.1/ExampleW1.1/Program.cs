using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleW1._1
{
    class Program
    {
        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            int n = args.Length;
            for (int i = 0; i < n; i++)
            {
                string s = args[i];
                int p = int.Parse(s);

                if (isEven(p) == false)
                {
                    Console.WriteLine(p);
                    Console.ReadKey();
                }
            }
           
        }
    }
}
