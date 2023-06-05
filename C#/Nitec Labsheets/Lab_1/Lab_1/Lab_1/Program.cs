using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            Console.WriteLine("Please Enter 2 numbers to add ");
            Console.WriteLine("First Number is:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number is:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of a and b is:");
            Console.WriteLine(a + b);

            Console.WriteLine("Please Enter 2 numbers to subtract");
            Console.WriteLine("First Number is:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number is:");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The difference of c and d is:\n{c - d}");

            Console.ReadKey();

        }
    }
}