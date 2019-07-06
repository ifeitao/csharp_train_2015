using System;
using System.Collections.Generic;

namespace Shape
{
    class Program
    {
        static void Main()
        {
            Rectangle r1 = new Rectangle(3, 4);
            Console.WriteLine(r1.Area);
            Rectangle r2 = new Square(3);
            Console.WriteLine(r2.Area);
            r1.Zoom(2,3);
            Console.WriteLine(r1.Area);
            //r2.Zoom(2,3);
            ((Square)r2).Zoom(3);
            Console.WriteLine(r2.Area);
            Console.ReadKey();

            List<Rectangle> list = new List<Rectangle>(16);
            list.Add(new Rectangle(1, 2));
            list.Add(new Rectangle(1, 3));
            list.Add(new Rectangle(1, 4));
            list.Add(new Rectangle(1, 5));
            list.Add(new Rectangle(1, 6));
            list.Add(new Square(1));
            list.Add(new Square(2));
            list.Add(new Square(3));
            list.Add(new Square(4));
            foreach (var rectangle in list)
            {
                Console.WriteLine("Length={0},Width={1},Area={2}", rectangle.Length, rectangle.Width, rectangle.Area);
            }
            Console.ReadKey();

            foreach (var rectangle in list)
            {
                rectangle.Zoom(2, 3);
                Console.WriteLine("Length={0},Width={1},Area={2}", rectangle.Length, rectangle.Width, rectangle.Area);
            }
            Console.ReadKey();

        }
    }
}
