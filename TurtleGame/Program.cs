using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Console.Title = "Догони куб 3 раза";

            Turtle.PenUp();
            Turtle.Speed = 4;

            // (food) - объект который нужно поймать 3 Раза.
            var food = Shapes.AddRectangle(10, 10);
            int x = 30;
            int y = 40;
            Shapes.Move(food, x , y);


            Random rnd = new Random();

            // Синий куб ускорения.
            GraphicsWindow.BrushColor = "Blue"; 
            var speed = Shapes.AddRectangle(40, 50);
            int x1 = 200;
            int y1 = 300;
            Shapes.Move(speed, x1, y1);
            
            GraphicsWindow.DrawText(200, 280, "Ускорься)");
           
           

            while (true)
            {   //                                              |    
                //если координаты Черепахи и food пересекаются--+-- , food исчезает , затем рандомно(rnd) появляется на карте.
                /*                                              |
                 скорость черепахи снижатся на 1, при каждом касании food'а. 
                 */
                if (Turtle.X >= x && Turtle.X <= x + 20 && Turtle.Y >= y && Turtle.Y <= y + 20)
                {
                    x = rnd.Next(0, GraphicsWindow.Width);
                    y = rnd.Next(0, GraphicsWindow.Height);
                    Shapes.Move(food, x, y);
                    Turtle.Speed--;
                    
                    GraphicsWindow.BrushColor = "Red";
                    GraphicsWindow.DrawText(200, 260, "Осталось 2 раза =)");

                    if (Turtle.X >= x && Turtle.X <= x + 20 && Turtle.Y >= y && Turtle.Y <= y + 20)
                    {
                       

                        GraphicsWindow.BrushColor = "Red";
                        GraphicsWindow.DrawText(200, 260, "Осталось 2 раза =)");

                    }
                }

                // Синий куб ускорения.
                if (Turtle.X >= x1 && Turtle.X <= x1 + 35 && Turtle.Y >= y1 && Turtle.Y <= y1 + 35)
                {
                    Turtle.Speed = 7;
                }
                Turtle.Move(10);
            }
        }

        public static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }    
    }
}
