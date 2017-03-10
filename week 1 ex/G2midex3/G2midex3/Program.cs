using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace G2midex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            DirectoryInfo dr = new DirectoryInfo(s);
            FileSystemInfo[] f = dr.GetFileSystemInfos();

            foreach (FileSystemInfo file in f)
            {
                if (file.Name.Contains("test"))
                Console.WriteLine(file.Name);
            }
            Console.ReadKey();
        }
    }
}
