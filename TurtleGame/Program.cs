using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();


            GraphicsWindow.BrushColor = "Red";
            var food = Shapes.AddRectangle(10, 10);
            int x = 200;
            int y = 200;
            Shapes.Move(food, x, y);

            Random rand = new Random();
            

            while (true)
            {
                Turtle.Move(10);
                if(Turtle.X>=x && Turtle.X <= (x+15) && Turtle.Y >= y && Turtle.Y <= (y+15))
                {
                    x = rand.Next(0, GraphicsWindow.Width);
                    y = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(food, x, y);
                    Turtle.Speed = Turtle.Speed+0.5;
                }
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = -90;
            }
            else if(GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }

        }
    }
}
