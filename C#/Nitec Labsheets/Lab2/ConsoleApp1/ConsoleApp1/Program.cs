using System;
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int option = 0;
            Console.WriteLine("Please enter your option:");
            Console.WriteLine("(1) Addition a + b");
            Console.WriteLine("(2) Subtration a - b");
            Console.WriteLine("(3) Multiplication a * b");
            Console.WriteLine("(4) Division a / b");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for operand a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for operand b : ");
            b = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                Console.Write("The sum of a and b is ");
                Console.WriteLine(a + b);
            }
            else if (option == 2)
            {
                Console.Write("The difference between a and b is ");
                Console.WriteLine(a - b);
            }
            else if (option == 3)
            {
                Console.Write("The product of a and b is ");
                Console.WriteLine(a * b);
            }
            else if (option == 4)
            {
                Console.Write("The division of a by b is ");
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("Please select a valid option");
            }
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}