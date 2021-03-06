﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeTotal
{
    [Serializable]
    public class Snake : Drawer
    {
        int dx, dy;
        
        public Snake(ConsoleColor color, char sign, List<Point> body) : base(color, sign, body)
        {
            dx = 0;
            dy = 1;
        }

        public void Move(int a, int b)
        {
            dx = a;
            dy = b;
        }

        public void Move()
        {
            while (!Game.GameOver)
            {                                                
                Delete();
                for (int i = body.Count - 1; i > 0; i--)
                {
                    body[i].x = body[i - 1].x;
                    body[i].y = body[i - 1].y;
                }

                body[0].x += dx;
                body[0].y += dy;

                if (body[0].x >= 70)
                    body[0].x = 0;
                if (body[0].y >= 35)
                    body[0].y = 0;

                if (body[0].x < 0)
                    body[0].x = 70;
                if (body[0].y < 0)
                    body[0].y = 35;

                for (int i = 0; i < Game.wall.body.Count; i++)
                {
                    if (Game.snake.body[0].x == Game.wall.body[i].x && Game.snake.body[0].y == Game.wall.body[i].y)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(30, 10);
                        Console.WriteLine("GAME OVER");
                        Console.ReadKey();
                        Game.GameOver = true;
                    }
                }

                for (int i = 2; i < Game.snake.body.Count; i++)
                {
                    if (Game.snake.body[0].x == Game.snake.body[i].x && Game.snake.body[0].y == Game.snake.body[i].y)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(30, 10);
                        Console.WriteLine("GAME OVER");
                        Console.ReadKey();
                        Game.GameOver = true;
                    }
                }

                Draw();

                if (CanEat(Game.food))
                {
                    Game.food.SetRandomPosition();
                }

                if (body.Count == 5)
                {
                    Game.wall.LoadLevel(2);
                }

                if (body.Count == 10)
                {
                    Game.wall.LoadLevel(3);
                }
               
                Thread.Sleep(100);

            }
        }

        public void Delete()
        {
            foreach (Point i in body)
            {
                Console.SetCursorPosition(i.x, i.y);
                Console.Write(' ');
            }
        }

        public bool CanEat(Food f)
        {
            if (body[0].x == f.body[0].x && body[0].y == f.body[0].y)
            {
                body.Add(new Point(f.body[0].x, f.body[0].y));
                return true;
            }

            return false;

        } 
    }
}
