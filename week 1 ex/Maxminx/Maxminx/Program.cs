using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Maxminx
{
    class Program
    {
        static void sum()
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int a = int.Parse(arr[i]);
                sum = sum + a;
            }

            Console.Write(sum);
            Console.ReadKey();
            
       }
        


       static void Main(string[] args)
        {
            sum();
        }
    }
}
