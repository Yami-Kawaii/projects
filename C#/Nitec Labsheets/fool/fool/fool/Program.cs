using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fool
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                bool a = false;
                for (int n = 2; n <= i;  n++)
                {
                    if (n % i == 0)
                    {
                        a = true;
                        break;
                    }
             if (a == false)
                    {
                        Console.WriteLine(i);
                    }


                }
            }
            Console.ReadKey();
        }
    }
}
