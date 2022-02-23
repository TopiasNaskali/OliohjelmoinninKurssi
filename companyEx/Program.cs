using System;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Company firm1 = new Company();
            firm1.title = "Programmers Oy";
            firm1.address = "Oravakatu 3, 53100 Lappeenranta";
            firm1.phone_number = "020 397465";
            firm1.outcome = 1000000.20;
            firm1.expense = 22.69;
            firm1.PrintInfo();
            Console.WriteLine("firm1-olio: " + firm1.ToString());
            firm1.CalculateProfit();
            firm1.FirmStatus();

            
            Console.WriteLine("\n\nfirm2");
            Company firm2 = new Company();
            firm2.title = "Ohjelmoijat Oy";
            firm2.address = "Purjotie 22 53100 Lappeenranta";
            firm2.phone_number = "020 736483";
            firm2.outcome = 2000000.27;
            firm2.expense = 574655.54;
            firm2.PrintInfo();
            Console.WriteLine("firm2-olio: " + firm2.ToString());
            firm2.CalculateProfit();
            firm2.FirmStatus();
            

            Console.WriteLine("\n\nfirm3");
            Company firm3 = new Company(firm2);
            firm3.PrintInfo();
            Console.WriteLine("firm3-olio: " + firm3.ToString());
            firm3.CalculateProfit();
            firm3.FirmStatus();
        }
            
        }
    }

