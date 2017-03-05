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
            FileStream fs = new FileStream(@"C:\Users\Айжан\Documents\input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();
            string[] arr = s.Split();

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int a = int.Parse(arr[i]);
                sum = sum + a;
            }

            
            

            sr.Close();
            fs.Close();
            

           f2(sum);



        

        }
        static void f2(int k)
        {
            FileStream sf = new FileStream(@"C:\Users\Айжан\Documents\output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter rs = new StreamWriter(sf);

            int s = k;

            Console.WriteLine(k);
            rs.Write(k);
            rs.Close();
            sf.Close();
            


            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            sum();
        }
    }
}
