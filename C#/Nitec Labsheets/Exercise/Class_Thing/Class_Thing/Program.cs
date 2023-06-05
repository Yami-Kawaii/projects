using System;
using System.Linq;

namespace Class_Thing
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Shoes[] shoeList = new Shoes[999];
            string model="";
            string size="";

            while (true)
            {
                Console.Write("Enter shoe model:");
                model = Console.ReadLine();
                Console.Write("Enter shoe size:");
                size = Console.ReadLine();

                shoeList[counter] = new Shoes(model, size);
                counter++;

                Console.WriteLine("Would you like to continue?");
                string a = Console.ReadLine();

                if (a == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }

            foreach(var shoe in shoeList)
            {
                try
                {
                    Console.WriteLine($"\nModel:{shoe.model}\tAvalibile:{shoe.modelCheck(model)}\nSize:{shoe.size}\t\tAvalibile:{shoe.sizeCheck(size)}");
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}