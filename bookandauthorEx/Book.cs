using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAndAuthor
{
    class Book
    {
        private const long MaxLength = 13;

        private string name;
        private string author;
        private string publisher;
        private double price;
        private string isbn;
        public static string themeName = "Dark";
        private string theme;



        public Book()
        {
            this.Name = string.Empty;
            this.Author = string.Empty;
            this.Publisher = string.Empty;
            this.Price = 0;
            this.Isbn = string.Empty;
            this.Theme = themeName;
        }

        public string Theme
        {
            get => theme;
            set => theme = value;
        }
        public string Isbn
        {
            get
            {
                return isbn;
            }
            set
            {
                if (value.Length > MaxLength)
                {
                    Console.WriteLine("isbn is too long");
                }
                else
                {
                    isbn = value;
                }
            }
        }
                public string Name { get => name; set => name = value; }
                public string Author { get => author; set => author = value; }
                public string Publisher { get => publisher; set => publisher = value; }
                public double Price { get => price; set => price = value; }
        public void GetBookDetails()
        {
            //isbn.CompareTo(Isbn);
            if (this.isbn == Isbn)
            {
                Console.WriteLine($"Book title: {this.Name}, Author: {this.Author}, Publisher {this.Publisher}, price: {this.Price} , ISBN code: {this.Isbn}, Theme: {this.Theme}");
            }
            else
            {
                Console.WriteLine("the information is wrong");
            }
        }

            public void PrintInfo()
            {
                Console.WriteLine($"Book title: {this.Name}, Author: {this.Author}, Publisher {this.Publisher}, price: {this.Price} , ISBN code: {this.Isbn}");
            }

            public void ChangeTheme(string themename)
        {
            string teema = theme;
            this.theme = themename;
        }

        
        
            

               
              

        }
    }

    

         
    

