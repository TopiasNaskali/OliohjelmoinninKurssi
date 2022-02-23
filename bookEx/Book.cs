using System;
using System.Collections.Generic;
using System.Text;

namespace Olioohjelm
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public double price;

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.id = SetId(id);
            this.price = price;
        }
       
        public string SetId(string idvalue)
        {
            if (idvalue.Length == 5)
            {
                return idvalue;
            }
            else
            {
                return "Id value does not match";
            }
            



        }


        public string GetBook()
        {
            return ($"Title: {this.title}, Author: {this.author}, Id: {this.id}, Price: {this.price}");
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Title: {this.title}, Author: {this.author}, Id: {this.id}, Price: {this.price}");
        }

      
        public void CompareBooks(Book Book)
        {
            double max = Math.Max(this.price, Book.price);
            if (max < this.price)
            {
                Console.WriteLine($"Tämä kirja: , {this.title}, on kalliimpi kuin: , {Book.title}");

            }
            else
            {
                Console.WriteLine($"Tämä kirja: , {Book.title}, on kalliimpi kuin: , {this.title}");
            }





        }

    }
}
