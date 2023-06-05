using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_F
{
    class Program
    {
        static void Main(string[] args)
        {
            int user = 12;
            int password = 1234;
            int counter = 0;
            do
            {
                Console.Write("Enter a user: ");
                int temp_user = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a password: ");
                int temp_password = Convert.ToInt32(Console.ReadLine());

                if (temp_user == user && temp_password == password)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                {
                    Console.WriteLine("Login Error");
                }
                counter++;
            }
            while (counter <= 3);
            Console.ReadKey();
        }
    }
}
