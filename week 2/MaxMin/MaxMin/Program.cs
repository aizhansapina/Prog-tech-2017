using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxMin
{
    class Program
    {
        static void f1()
        {
            FileStream fs = new FileStream(@"C:\Users\Айжан\Documents\www.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);


            string s = sr.ReadLine(); 
            string[] arr = s.Split(); 


            int maxi = int.Parse(arr[0]);

            for (int i = 0; i < arr.Length; i++)
            {
                int t = int.Parse(arr[i]);
                if (t > maxi)
                {
                    maxi = t;
                }


            }
            Console.Write(maxi);

            sr.Close();
            fs.Close();

            Console.ReadKey();

        }

        static void f2()
        {
            FileStream fs = new FileStream(@"C:\Users\Айжан\Documents\www.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);


            string s = sr.ReadLine(); 
            string[] arr = s.Split(); 

            int mini = int.Parse(arr[0]);

            for (int i = 0; i < arr.Length; i++)
            {
                int t = int.Parse(arr[i]);
                if (t < mini)
                {
                    mini = t;
                }


            }
            Console.Write(mini);

            sr.Close();
            fs.Close();

            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            f1();
            
        }
    }
}