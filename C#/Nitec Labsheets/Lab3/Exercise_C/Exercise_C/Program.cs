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
            Console.Write("Enter a symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the deisred height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= height; i++)
            {
                string border = "";
                if (i==1 || i == height)
                {
                    for (int n=1;n <= width; n++)
                    {
                        border = border + symbol;
                    }
                    Console.WriteLine(border);
                }
                else
                {
                    for (int n = 1; n <= width; n++)
                    {
                        if (n == 1 || n == width)
                        {
                            border = border + symbol;
                        }
                        else
                        {
                            border = border + " ";
                        }
                    }
                    Console.WriteLine(border);
                }
            }
            Console.ReadKey();
        }
    }
}
