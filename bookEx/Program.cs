using System;

namespace Olioohjelm
{
    class Program
    {
        static void Main(string[] args)
        {
            var Book1 = new Book("Bendtner: Both sides ,", "Rune Skyum-Nielsen ,", "83453", 13.90);
            var Book2 = new Book("Suomen lintuopas, ", "Pertti Lintukoski, ", "8383", 7.90);
            Console.WriteLine(Book1.GetBook());
            Console.WriteLine();

            Console.WriteLine(Book2.GetBook());
            Console.WriteLine();

            Book1.CompareBooks(Book2);

            

        }
    }
}
