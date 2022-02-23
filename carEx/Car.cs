using System;
using System.Collections.Generic;
using System.Text;

namespace CarExercise
{
    class Car
    {

        public string inputBrand;
        public int inputSpeed;
        /*public string accerelate;
        public string accerelation;*/

        public Car()
        {
            this.inputBrand = string.Empty;
            this.inputSpeed = 0;

        }

        public Car(Car car)
        {
            this.inputBrand = string.Empty;
            this.inputSpeed = 0;
        }
        public void AskData()
        {
            Console.Write("Enter the car brand: ");
            this.inputBrand = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Enter the car speed: ");
            this.inputSpeed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Brand: {this.inputBrand}, Speed; {this.inputSpeed} ");
        }
        public void Accerelate()
        {
            Console.WriteLine("How much more speed you would like?");
            int speedi = Convert.ToInt32(Console.ReadLine()); 
            
            if (speedi < 0)

            {
                Console.WriteLine("you have to input a positive number");
                
            }
            else
            {
                this.inputSpeed = this.inputSpeed + speedi;
                Console.WriteLine($"You have added: {speedi} amount of speed, the new top speed is: { this.inputSpeed}");
            } }

        public void Brake()
        {
            int jarru = Convert.ToInt32(0.9 * this.inputSpeed);
            this.inputSpeed = jarru;
            Console.WriteLine("auto vähentää nopeutta ja uusi nopeus on " + this.inputSpeed); 

        }
        
    
    }


    }

    