﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeTotal
{
    public class Game
    {
        public static bool GameOver;
        public static Snake snake;
        public static Food food;
        public static Wall wall;

        public static Thread SnakeMover;

        public static void Init()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 35);

            GameOver = false;

            // snake Init
            List<Point> snake_body = new List<Point>();
            snake_body.Add(new Point(10, 10));
            snake_body.Add(new Point(9, 10));
            snake = new Snake(ConsoleColor.Magenta, 'o', snake_body);

            // wall Init    
            List<Point> wall_body = new List<Point>();
            wall = new Wall(ConsoleColor.Cyan, '#', wall_body);

            // food Init
            List<Point> food_body = new List<Point>();
            food_body.Add(new Point(0, 0));
            food = new Food(ConsoleColor.Red, '*', food_body);

            Draw();

            SnakeMover = new Thread(snake.Move);
            SnakeMover.Start();

        }

        public static void Draw()
        {
            Console.Clear();
            snake.Draw();
            food.Draw();
            wall.Draw();
        }

        public static void Cases()
        {
            while (!GameOver)
            {
                ConsoleKeyInfo button = Console.ReadKey();
                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        snake.Move(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        snake.Move(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        snake.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        snake.Move(1, 0);
                        break;
                    case ConsoleKey.Escape:
                        GameOver = true;
                        break;
                    case ConsoleKey.F2:
                        snake.save();
                        wall.save();
                        food.save();
                        break;
                    case ConsoleKey.F3:
                        loadGame();
                        break;
                }
            }
        }

        public static void loadGame()
        {
            SnakeMover.Abort();

            Console.Clear();

            wall.release();
            snake.release();
            food.release();

            Draw();

            SnakeMover = new Thread(snake.Move);
            SnakeMover.Start();


        }
    }
}
