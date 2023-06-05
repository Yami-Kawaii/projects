using System;

namespace db
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] list = new string[5];
            Console.WriteLine("Please enter 5 names");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"Enter name #{i+1}: ");
                string value = Console.ReadLine();
                list[i] = value;
            }

            Console.WriteLine("Please enter a name to search");
            string name = Console.ReadLine();
            for (int j = 0; j < list.Length; j++)
            {
                if (list[j] == name)
                {
                    Console.WriteLine("found.");
                    break;
                }
                else if (j == 4 && list[j] != name)
                {
                    Console.WriteLine("not found.");
                }
            }
            Console.ReadLine();
        }
    }
}
