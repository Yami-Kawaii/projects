using System;

namespace for2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Numero {i} = ");
                if (i % 2 == 0)
                {
                    a = $"{a} {Convert.ToString(i)}";
                }
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
