using System;

namespace BookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book
            {
                Name = "Ruotsin mafia",
                Author = "Lasse Vierup & Matti Larsson",
                Publisher = "Word Audio Publishing",
                Price = 14.95
            };

            /*Console.WriteLine($"/*Book title: {book1.Name}, Author: {book1.Author}, Publisher {book1.Publisher}, price: {book1.Price} , ISBN code: {book1.Isbn}");*/
                book1.Isbn = "9789510482889";
           
            book1.GetBookDetails();

            book1.ChangeTheme("light");
            book1.GetBookDetails();
            Console.ReadLine();
            //book1.PrintInfo();

            //Book book1 = new Book("Ruotsin mafia, Lasse Vierup & Matti Larsson", 14.95, 9789510482889, "Reality crime");


        }
    }
}
