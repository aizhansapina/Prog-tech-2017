using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Wall wall = new Wall();

            while (true)
            {
                ConsoleKeyInfo press = Console.ReadKey();
                if (press.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (press.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (press.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (press.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);

                if (press.Key == ConsoleKey.Escape)
                    break;

                Console.Clear();
                snake.Draw();
                wall.Draw();


            }
        }
    }
}
