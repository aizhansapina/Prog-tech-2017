using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Far
{
    class Program
    {
        static void ShowInfo(DirectoryInfo directory, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.White;
            int index = 0;
            foreach (FileSystemInfo fInfo in directory.GetFileSystemInfos())
            {
                if (index == cursor)
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                else
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                index++;
                if (fInfo.GetType() == typeof(FileInfo))
                    Console.Write("File: ");
                else
                    Console.Write("Directory: ");
                Console.WriteLine(fInfo.Name);
            }
        }
        static void Main(string[] args)
        {
            int cursor = 0;
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Айжан\Documents");
            while (true)
            {
                Console.Clear();
                ShowInfo(directory, cursor);
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.UpArrow)
                    if (cursor > 0)
                        cursor--;
                if (pressedKey.Key == ConsoleKey.DownArrow)
                    if (cursor < directory.GetFileSystemInfos().Length - 1)
                        cursor++;
                if (pressedKey.Key == ConsoleKey.Enter)
                {
                    FileSystemInfo fi = directory.GetFileSystemInfos()[cursor];
                    directory = new DirectoryInfo(fi.FullName);
                }
                if (pressedKey.Key == ConsoleKey.Backspace)
                {
                    try
                    {
                        directory = Directory.GetParent(directory.FullName);
                    }
                    catch (Exception e)
                    {

                    }
                }
                if (pressedKey.Key == ConsoleKey.Escape)

                    break;
            }
        }
    }
}
