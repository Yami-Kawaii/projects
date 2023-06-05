using System;
namespace Exercise_D
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("PLEASE ENTER A WHOLE NUMBER");
            int choice = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= choice; i++)
            {
                a = a +" "+Convert.ToString(i);
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
