using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PN
{
    class Program
    {
        static int IsPrime(int x)
        {
            int a = x;
            int cnt = 0;
            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    cnt++;
            }

            if (cnt == 2)
                return a;
            else
                return 0;
            
        }
        
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int b = int.Parse(s);
            int y;
            y = IsPrime(b);

            if (b == y)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            Console.ReadKey();

        }
    }
}
