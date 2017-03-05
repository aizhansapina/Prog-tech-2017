using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DIFI
{
    class Program
    {
        static void Ex1()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Айжан\Documents");
            Console.WriteLine(directory.Name);
            Console.WriteLine(directory.FullName);
            Console.ReadKey();
        }
        static void Ex2()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Айжан\Documents");
            
            // Getting files.
            FileInfo[] files = directory.GetFiles();

            // Getting directories
            DirectoryInfo[] directories = directory.GetDirectories();

            Console.WriteLine(files.Length);
            Console.WriteLine(directories.Length);
            Console.ReadKey();
        }
        static void Ex3()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Айжан\Documents");
            FileInfo[] files = directory.GetFiles();

            
            DirectoryInfo[] directories = directory.GetDirectories();

            Console.WriteLine("Files:");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Directories:");

            foreach (DirectoryInfo dInfo in directories)
            {
                Console.WriteLine(dInfo.Name);
            }
            Console.ReadKey();
        }

        static void emptySpace(int level)
        {
            for (int i = 0; i < level * 2; i++)
                Console.Write(" ");
        }

        static void Ex4(string path, int level)
        {
            if (level > 2)
                return;
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                FileInfo[] files = directory.GetFiles();
                DirectoryInfo[] directories = directory.GetDirectories();

                foreach (FileInfo file in files)
                {
                    emptySpace(level);
                    Console.WriteLine(file.Name);
                }
                foreach (DirectoryInfo dInfo in directories)
                {
                    emptySpace(level);
                    Console.WriteLine(dInfo.Name);
                    Ex4(dInfo.FullName, level + 1);
                }
            }
            catch (Exception e)
            {

            }
        }

        static void Ex5()
        {
            StreamWriter st = new StreamWriter(@"C:\Users\Айжан\Documents\a.txt");
            st.WriteLine("Hello world");
            st.Close();
        }

        static void Ex6()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Айжан\Documents\input1.txt");
            string s = sr.ReadLine(); 
            string[] arr = s.Split(); 
            int a = int.Parse(arr[0]); 
            int b = int.Parse(arr[1]); 
            Console.WriteLine(a + b); 
            Console.ReadKey();
            sr.Close();
        }

        static void Ex7()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Айжан\Documents\input1.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Айжан\Documents\output1.txt");
            string[] arr = sr.ReadLine().Split();
            int sum = 0;
            foreach (string s in arr)
            {
                sum += int.Parse(s);
            }
            sw.WriteLine(sum);
            sr.Close();
            sw.Close();
        }

        class Point
        {
            int x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return x + " " + y;
            }
        }

        static void Ex8()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Айжан\Documents\points.txt");
            string[] arr = sr.ReadLine().Split(); 
            List<Point> points = new List<Point>();

            foreach (string s in arr)
            {
                
                string[] a = s.Split(':'); 
                Point p = new Point(int.Parse(a[0]), int.Parse(a[1]));
                points.Add(p);
            }

            foreach (Point p in points)
            {
                Console.WriteLine(p);
            }
            sr.Close();
            Console.ReadKey();
        }
        
        static void Main(string[] args)
        {
            Ex8();
        }
    }
}
    
