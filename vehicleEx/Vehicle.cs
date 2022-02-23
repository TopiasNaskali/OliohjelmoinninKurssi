using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    abstract class Vehicle
    {
        protected string make;  //luokka
        protected string model;
        protected int modelYear;
        protected int price;

        //constructor
        public Vehicle()
        {
            Console.WriteLine("Vehicle-luokan muodostin");
            this.make = string.Empty;
            this.model = string.Empty;
            this.modelYear = 0;
            this.price = 0;
        }
        //constructor
        public Vehicle(string make, string model, int modelYear, int price)
        {
            this.make = make;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }
        public virtual void PrintInfo() //virtuaali
        {
            Console.WriteLine($"Merkki: {this.make}, Malli: {this.model}, Vuosimalli: {this.modelYear}, Hinta: {this.price} Euroa");
        }

        public override string ToString()
        {
            return $"{this.make}, {this.model}, {this.modelYear}, {this.price}";
        }
        abstract public void wrum(); 
        public string GetMake()
        {
            return this.make;
        }
      
    }
}
