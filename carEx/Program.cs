using CarExercise;
using System;


   class Program
    {
        static void Main(string[] args)
        {
        Car car = new Car();
        car.AskData();
        Console.WriteLine();

        car.ShowCarInfo();
        car.Accerelate();

        car.Brake();

        Console.ReadLine();






        }
    }

