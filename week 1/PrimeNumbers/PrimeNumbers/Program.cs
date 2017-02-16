using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {

        static int IsPrime(int x)
        {
            int a = x;
            int cnt = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    cnt++;
            }

            if (cnt == 2 || a == 1)
            {
                return a;
            }
            else
            {
                return 0;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers: ");
            string s = Console.ReadLine();

            string[] arr = s.Split();

            int y;
            int z;
            Console.WriteLine("prime numbers: ");

            for (int i = 0; i < arr.Length; i++)
            {
                y = int.Parse(arr[i]);
                z = IsPrime(y);
                if (z == y)
                {
                    Console.Write(y + " ");
                }

            }
            Console.ReadKey();
        }
    }
} 
