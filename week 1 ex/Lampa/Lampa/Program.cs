using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lampa
{
    class Program
    {
        public static void Lampa()
        {
            string p1 = "*******";
            string p2 = "*******";
            string p3 = "*******";
            string p4 = "*******";
            string p5 = "*******";
            int i = 0;
            string[] p = { p1, p2, p3, p4, p5 };
            while (true)
            {
                //Console.Clear();
                Console.Clear();
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                }
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                }
                if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(1000);
                i++;
                i %= 3;
            }
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread t = new Thread(Lampa);
            t.Start();

        }
    }
}
