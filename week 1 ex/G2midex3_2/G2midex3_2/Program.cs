using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace G2midex3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.ReadLine());
            string s = Console.ReadLine();
            DirectoryInfo directory = new DirectoryInfo(s);
            FileSystemInfo[] files = directory.GetFileSystemInfos();

            for (int i = 0; i < directory.GetFileSystemInfos().Length; i++)
            {
                if (files[i].GetType() == typeof(FileInfo))
                {
                    FileStream fs = new FileStream(@"C:\Users\Айжан\Documents", FileMode.Open, FileAccess.Read);
                }
            }
        }
    }
}
