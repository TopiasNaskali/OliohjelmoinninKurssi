using EmployeeExercise;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Employee [] employees = new Employee [4];
            employees[0] = new Employee(" John Johnson ", 98575, " Ceo ", 12122.20);
            employees[1] = new Employee(" Jack Jackson ", 85754, " Business Manager ", 10000.00);
            employees[2] = new Employee(" Mark Markson ", 75348, " Consultant ", 8968.45);
            employees[3] = new Employee(" Julia Juliansson ", 86484, " Secretary ", 4558.25);

            /*foreach (Employee currentEmployee in employees)
            {
                Console.WriteLine($"{currentEmployee.ToString()}");
            }*/
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"{employees[i].ToString()}");
                

                if (i < 3)
                {
                    Console.Write($" Verrataan seuraavaan: ");
                    Console.WriteLine(employees[i].compare(employees[i+1]));
                    
                }
                /*else
                {
                    Console.WriteLine($"{employees[i + 1].ToString()}");
                } */          
                }
        }
    }
}
