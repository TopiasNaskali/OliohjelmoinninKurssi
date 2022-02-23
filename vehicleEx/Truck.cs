using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Truck : Car
    {
        protected double load;
        protected double consumption;
        //protected double _consumption;

        public Truck()
        {
            this.load = 1220.2;
            this.consumption = 9.7;
           
        }
        public Truck(string make, string model, int modelYear, int price, string engine, string type, int doors, double load, double consumption): base (make,  model,  modelYear,  price,  engine, type, doors)
        {
            this.load = load;
            this.consumption = consumption;

        }
       /* public double GetLoad()
        {
            return this.load;
        }
        public double GetConsumption()
        {
            return this.consumption;
        }*/
        public void CalculateConsumption()
        {
            //Console.WriteLine($"{this._consumption}");
            double calc = (this.load / this.consumption);
            calc = Math.Round(calc, 2);
            double CalcdCons = calc;
            Console.WriteLine($"Kuorma-auton laskettu kulutus on: {calc}, litraa"); //logiikka varmaan vähä hukassa
        }

        public override void PrintInfo() //ylikirjoitus
        {
            base.PrintInfo();
            Console.WriteLine($"Lastin paino: {this.load}, Kuorma auton kulutus: {this.consumption}");
        
        }
        
    }
}
