using System;
using System.Collections.Generic;

namespace RajapintaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productsList = new List<Product>();
            productsList.Add(new Product("Kattovalaisin", 122.95, 200));
            productsList.Add(new Product("Jalkalamppu", 99.95, 300));
            productsList.Add(new Product("Pöytälamppu", 44.95, 350));
            Console.WriteLine("");
            foreach (Product currentProduct in productsList)
            {
                if (currentProduct.GetProduct("Kattovalaisin") != null)
                {
                    Console.WriteLine($"Kattovalaisimia löytyy");
                    Console.WriteLine($"Kattovalaisimien varaston arvo: {currentProduct.CalculateTotal()}");
                }
                Console.WriteLine(currentProduct.ToString());

            }

            Console.WriteLine("");
            //Customer customer1 = new Customer("Kimmo", 1200.20);
           List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer("Kimmo", 1222.95));
            customerList.Add(new Customer("Teppo", 990.95));
            customerList.Add(new Customer("Mari", 444.95));
            Console.WriteLine("");

            foreach (Customer currentCustomer in customerList)
            {
                if (currentCustomer.GetCustomer("Kimmo") != null)
                {
                    Console.WriteLine($"Kyseinen asiakas Kimmo löytyy");
                    Console.WriteLine($"{currentCustomer.GetBonus()}");
                    ;
                }
                Console.WriteLine(currentCustomer.ToString());



                Console.WriteLine("");
                Store myStore = new Store("Lamppukauppa", 837657.22);
                myStore.AddCustomer(new Customer("Kimmo", 1222.95));
                myStore.AddCustomer(new Customer("Teppo", 990.95));
                myStore.AddCustomer(new Customer("Mari", 444.95));
                myStore.AddProduct(new Product("Kattovalaisin", 122.95, 200));
                myStore.AddProduct(new Product("Jalkalamppu", 99.95, 300));
                myStore.AddProduct(new Product("Pöytälamppu", 44.95, 350));
                myStore.PrintCustomers();
                myStore.PrintProducts();
                Console.WriteLine(myStore.ToString());



            }
        }
    }
}
