using System;
using System.Collections.Generic;

namespace ShapeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Shape> allShapes = new List<Shape>
            {
                new Circle("red", 4),
                new Circle("green", 5),
                new Triangle("blue", 7, 12, 11),
                new Rectangle("black", 2, 3, 4),
            };

            foreach (Shape s in allShapes)
            {
                Console.WriteLine($"PI on {s.GetArea():F2}");
            }
        }
    }
}
