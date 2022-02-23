using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    class Company
    {
        public string title;
        public string address;
        public string phone_number;
        public double outcome;
        public double expense;
        

        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone_number = string.Empty;
            this.outcome = 0;
            this.expense = 0;
        }

      
       
        public Company(Company company) // copy constructor
        {
            this.title = company.title;
            this.address = company.address;
            this.phone_number = company.phone_number;
            this.outcome = company.outcome;
            this.expense = company.expense;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Yrityksen nimi: {this.title}, Osoite: {this.address}, Puh.nro {this.phone_number}, Tulot: {this.outcome} euroa, Menot: {this.expense} euroa");
        }

        public override string ToString()
        {
            return $"Yrityksen nimi: {this.title}, Osoite: {this.address}, Puh.nro {this.phone_number}, Tulot: {this.outcome} euroa, Menot: {this.expense} euroa";
        }
        public void CalculateProfit()
        {

            double profit = (this.outcome - this.expense) / this.outcome * 100;
            Console.WriteLine($"Yrityksen voitto:  {profit} euroa");
        }
        public void FirmStatus()
        {
            double profit = (this.outcome - this.expense) / this.outcome * 100;
            if (profit < this.expense * 2)
            {
                Console.WriteLine("Firmalla menee kehnosti ");
            }
            else if (profit >= this.expense * 2 && profit <= this.expense * 4)
            {
                Console.WriteLine("Firmalla menee välttävästi ");
            }
            else if (profit > this.expense * 4 && profit <= this.expense * 6)
            {

                Console.WriteLine("Firmalla menee tyydyttävästi ");
            }
            else
            {
                Console.WriteLine("Firmalla menee hyvin ");
            }
        }
    }
    }

