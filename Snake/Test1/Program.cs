using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            //draw the field
            Console.SetBufferSize(80, 25);

            Field field = new Field(80, 25, '+');
            field.Draw();
            
            //create Snake
            //Point pr = new Point(4, 6, '%');
            //pr.Draw();
            Point p = new Point(4, 5, '*');            
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            
            //create food
            Kitchen k = new Kitchen(80, 25, '$');
            Point food = k.Cooking();
            food.Draw();
            
            int s = 150;

            //snake move
            while (true)
            {
                //is there hit smth
                if (field.isHit(snake)||snake.isHitTail())
                {
                    break;
                }


                //is there dinner
                if (snake.Eat(food))
                {
                    food = k.Cooking();
                    //food.Draw();
                   // s = s - 10;
                }


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handle(key.Key);
                }
                food.Draw();
                Thread.Sleep(s);
                snake.Move();
            }

            Console.Clear();
            Console.SetCursorPosition(35, 10);
            
            Console.WriteLine("Game over");
            
            Console.ReadKey();
            
        }
    }
}
