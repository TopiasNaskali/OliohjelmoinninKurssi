using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vehicle vehicle1 = new Vehicle ("BMW", "Coupe", 2021, 96900);
            Vehicle vehicle2 = new Vehicle ("BMW", "Sedan", 2019, 144900);
            vehicle1.PrintInfo();
            vehicle2.PrintInfo();*/
             
            Car car1 = new Car("BMW", "Coupe", 2021, 96900, "2998cm3", "M440i", 3);
            Car car2 = new Car("BMW", "Sedan", 2019, 144900, "4495cm3", "M5", 5);
            car1.PrintInfo();
            car2.ToString();
            car2.PrintInfo();
            

            if (car1.Equals(car2))
            {
                Console.WriteLine($"Auto numero yksi on {car1.GetMake()} merkkinen, auto numero kaksi on {car2.GetMake()} merkkinen myös");
            }
            else
            {
                Console.WriteLine($"Auto numero yksi on {car1.GetMake()}, merkkinen, auto numero 2 on {car2.GetMake()}, merkkinen");
            }
            Truck truck1 = new Truck("Scania", "Kuorma-auto", 2019, 350000, "3497cm3", "Truckmaster9000", 2, 1520.37, 10.20);
            truck1.PrintInfo();
            truck1.CalculateConsumption(); //logiikka taas erittäin hukassa varmaankin
        }
    }
}
