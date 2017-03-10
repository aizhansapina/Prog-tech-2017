using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace G2midex3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Айжан\Documents\");
            string partialname = "input";
            string s = Console.ReadLine();
            DirectoryInfo df = new DirectoryInfo(s);
            //DirectoryInfo df = new DirectoryInfo(@"C:\Users\Айжан\Documents");
            FileInfo[] fs = df.GetFiles("*" + partialname + "*.*");

            foreach (FileInfo file in fs)
            {
                string fullname = file.FullName;
                Console.WriteLine(fullname);
            }
            Console.ReadKey();
        }
    }
}
