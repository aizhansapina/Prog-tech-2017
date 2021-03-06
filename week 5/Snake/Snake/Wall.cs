﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Snake
{
    class Wall
    {
        List<Point> body;
        public char sign = 'o';
        public ConsoleColor color;

        public Wall()
        {
            body = new List<Point>();
            color = ConsoleColor.DarkGray;

            StreamReader sr = new StreamReader(@"C:\Users\Айжан\Documents\wall.txt");
            int a = int.Parse(sr.ReadLine());

            for (int i = 0; i < a; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '*')
                        body.Add(new Point(j, i));
                }
            }

            sr.Close();
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}
