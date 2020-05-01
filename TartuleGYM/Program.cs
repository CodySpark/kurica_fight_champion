using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TartuleGYM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "череп паха";

            Turtle.Speed = 9;


            
            WordT( 200 , 200,90 );
           

            WordO(260 ,200 , 60);


           
            WordP(350 , 200 , 60 , 30);


          
            WordT(415 , 200, 60);
           
        }
        // T 
        static void WordT(int x , int y , int size) 
        {
            Turtle.X = x;
            Turtle.Y = y;

            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 270;
            Turtle.Move(size / 3);
            Turtle.Angle = 90;
            Turtle.Move(size * 2 /3);
           
        }

        // O 
        static void WordO(int x, int y ,int size)
        {
            Turtle.X = x;
            Turtle.Y = y;

            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
            
        }

        //p
        static void WordP(int x, int y , int size , int size2) 
        {
            Turtle.X = x;
            Turtle.Y = y;

            Turtle.Angle = 0;
            Turtle.Move(size);
            for (int i = 0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(size2);
            }
           
        }

    }
}
