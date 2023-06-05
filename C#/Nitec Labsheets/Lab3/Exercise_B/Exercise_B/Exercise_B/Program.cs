using System;
namespace Exercise_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method 1");
            for (int i = 10; i <= 20; i += 2)
            {
                if (i == 16)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("\nMethod 2:");
            for (int i = 10; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                if (i == 16)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("\nMethod 3:");
            for (int i = 10; ; i += 2)
            {
                if (i == 16)
                    continue;
                if (i > 20)
                    break;
            Console.ReadKey();
            }
        }    
    }
}


