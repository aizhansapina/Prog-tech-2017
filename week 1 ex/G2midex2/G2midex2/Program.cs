using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace G2midex2
{
    class Program
    {
        

        /*public static void f1()
        {
            FileStream fs = new FileStream(@"C:\Users\Айжан\Documents\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();
            string[] arr = s.Split();

            int a = arr.Length;

            int A = int.Parse(arr[0]);
            int B = int.Parse(arr[1]);

            for (int i = 1; i <= A; i++)
            {
                if (A % i == 0 && B % i == 0)
                {
                    i++;

                }
            }

            fs.Close();
            sr.Close();
            f2(a);
        }

        public static void f2(int a)
        {
            FileStream sf = new FileStream(@"C:\Users\Айжан\Documents\output.txt", FileMode.Open, FileAccess.Read);
            StreamWriter sw = new StreamWriter(sf);

            int c = a;

            sf.Close();
            sw.Close();
            sw.WriteLine(i);
        }*/


        static void Main(string[] args)
        {
            
            StreamReader sr = new StreamReader(@"C:\Users\Айжан\Documents\input.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Айжан\Documents\output.txt");


            string s = sr.ReadLine();
            string[] arr = s.Split();

            int a = arr.Length;

            int A = int.Parse(arr[0]);
            int B = int.Parse(arr[1]);

            if (A > B)
                for (int i = 1; i <= B; i++)
                {
                    if (A % i == 0 && B % i == 0)
                        
                    sw.WriteLine(i + " ");
                }
            else
                for (int i = 1; i <= A; i++)
                {
                    if (A % i == 0 && B % i == 0)
                        
                    sw.WriteLine(i + " ");
                }


            sr.Close();
            sw.Close();

            Console.ReadKey();
        }
    }
}
