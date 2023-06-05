using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number....");
            int numb = Convert.ToInt32(Console.ReadLine());
            int y = 1;

            for (int i = 1; i <= numb; i++)
            {
                y = y * i;
                Console.WriteLine($"Multiplied by {i} y is: {y}");
            }
            Console.WriteLine($"---------------------------\nThe factorial is: {y}");
            Console.ReadKey();
        } 
    }
}
