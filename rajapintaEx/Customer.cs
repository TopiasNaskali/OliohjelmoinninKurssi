using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajapintaExercise
{
    class Customer : ICustomer
    {
        private string name;
        private double purchases;
        private List<Customer> allCustomers = new List<Customer>();

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        /*public string GetBonus()
        {
            int a = 3;
            double inta = Convert.ToDouble(a);
            if (this.purchases > 999 && this.purchases < 2001)
            {
                return $"{this.purchases}, kyseisen asiakkaan bonus on 3%";
               // return inta;
                //Console.WriteLine($"{this.purchases}")
            }
        }*/

        public Customer GetCustomer(string name)
        {
            if (name == this.name)
            {
                return this;
            }
            else
            {
                return null;
            }
        }



        public string GetBonus()
        {
            if (this.purchases > 999 && this.purchases < 2001)
            {
                return $"Asiakkaan ostosten kokonaishinta {this.purchases}, kyseisen asiakkaan bonus on 3%";
                //Console.WriteLine ($"Kyseisen asiakkaan bonus on 3%");
            }
            else if (this.purchases < 1001)
            {

                return $"Asiakkaan ostosten kokonaishinta {this.purchases}, Kyseisen asiakkaan bonus on 2%";
            }
            else
            {
                return $"Asiakkaan ostosten kokonaishinta {this.purchases}, Kyseisen asiakkaan bonus on 5%";
            }
        }
            public void AddCustomer (Customer customer)
            {
                this.allCustomers.Add(customer);
            }
        public void PrintCustomers()
        {
            foreach (Customer customer in allCustomers)
            {
                Console.WriteLine(customer.ToString());
            }
        }


        public override string ToString()
        {
            return $"Asiakas {this.name}, ostosten kokonais summa; {this.purchases}";
        }
    }
}
