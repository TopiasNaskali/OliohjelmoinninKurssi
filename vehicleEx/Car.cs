using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : Vehicle //perii
    {
        protected string engine;    //luokka
        protected string type;
        protected int doors;
        
        //constructor
        public Car()
        {
            Console.WriteLine("Car-luokka");
            
            this.engine = "4395 cm3";
            this.type = "M5";
            this.doors = 5;
        }
        //constructor
        public Car(string make, string model, int modelYear, int price, string engine, string type, int doors):base (make, model, modelYear, price)
        {
            
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        public override bool Equals(object obj)
        {
            return obj is Car car &&
            make == car.make;//&&
            //price > 100000;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void PrintInfo() //ylikirjoitus
        {
            base.PrintInfo();
            Console.WriteLine($"Moottorin koko: {this.engine}, Malli: {this.type}, Ovien lukumäärä: {this.doors}");
        }

        public override string ToString()
        {
            return $"{this.engine}, { this.type}, { this.doors}";
        }

        public override void wrum()
        {
            Console.WriteLine($"Wrum Wrum");
        }
    }
}
