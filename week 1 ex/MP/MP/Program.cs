using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MP
{
    class Program
    {
        public static int IsPrime(int x)
        {
            int a = x;
            int cnt = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    cnt++;
            }
            if (cnt == 2)
                return a;
            else
                return 0;
        }

        static void f1()
        {
            FileStream fs = new FileStream(@"C:\Users\Айжан\Documents\www.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            
            //string[] arr = s.Split();
            int b = int.Parse(s);
            int z = IsPrime(b);
            if (z == b)
            {
                Console.WriteLine(z);
            }
            else
            {
             
            }

            Console.ReadKey();
            fs.Close();
            sr.Close();
            f2(z);
}
        static void f2(int y)
        {
            FileStream sf = new FileStream(@"C:\Users\Айжан\Documents\rrr.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(sf);

            int v = y;
            sf.Close();
            sw.Close();
            sw.WriteLine("yes");

            
       
        }


        

        static void Main(string[] args)
        {
            f1();
        }
    }
}
