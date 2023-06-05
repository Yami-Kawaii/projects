using System;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = { 5, 10, 15, 20, 25 };
            for (int i = 0; i < price.Length; i++)
            {
                price[i] += 12;
                Console.WriteLine(price[i]);
            }
            Console.ReadKey();
        }
    }
}
