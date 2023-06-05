using System;

namespace EBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Ebook potter = new Ebook("Harry Potter", 500, 1);
            Ebook rings = new Ebook("The Lord of the RIngs", 899, 20);

            Console.WriteLine($"{potter.cPage}");
            Console.ReadKey();  
        }
    }
}
