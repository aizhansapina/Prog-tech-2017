using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Farlab
{
    class Program
    {
        public static void Info(DirectoryInfo directory, int cursor)
        {
            int ind = 0;
            foreach (FileSystemInfo finfo in directory.GetFileSystemInfos())
            {
                if (ind == cursor)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                ind++;
                if (finfo.GetType() == typeof(FileInfo))
                    Console.WriteLine("File:");
                else
                    Console.WriteLine("Directory:");
                Console.WriteLine(finfo.Name);
                ind++;
            }

        }
        static void Main(string[] args)
        {
            Console.Clear();
            //Info(directory, cursor);
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Айжан\Documents");
            while (true) { 
            int cursor = 0;

            Info(directory, cursor);
            ConsoleKeyInfo press = Console.ReadKey();

                for (int i = 0; i < directory.GetFileSystemInfos().Length; i++)
                {
                    if (press.Key == ConsoleKey.UpArrow)
                        if (cursor > 0)
                            cursor--;
                    if (press.Key == ConsoleKey.DownArrow)
                        if (cursor < directory.GetFileSystemInfos().Length)
                            cursor++;

                }
            }
        }
    }
}
