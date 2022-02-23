using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajapintaExercise
{
    class Store : IProducts
    {
        private string name;
        private double revenue;
        private List<Customer> allCustomers = new List<Customer>();
        private List<Product> allProducts = new List<Product>();

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }
        /*public void AddProductsList(List<Product> list)
        {

        }*/

        public void AddProduct(Product product)
        {
            this.allProducts.Add(product);
        }

        public void PrintProducts()
        {
            foreach (Product product in allProducts)
            {
                Console.WriteLine(product.ToString());
            }
        }
        public void AddCustomer(Customer customer)
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
            return $"Kaupan nimi: {this.name}, Kaupan liikevaihto {this.revenue} euroa";
        }
    }
}
