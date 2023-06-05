using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the command keyword to exit a loop in C#? \na.  Quit\nb.  Continue\nc.  Break\nd.  Exit ");
            while (true)
            {
                Console.Write("Enter your choice: ");
                char choice = Convert.ToChar(Console.ReadLine());
                if (choice == 'c')
                {
                    Console.WriteLine("Congratulation!\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
                Console.Write("Again? press y to continue: ");
                char stop = Convert.ToChar(Console.ReadLine());
                if (stop != 'y')
                {
                    break;
                }
            }
        }
    }
}