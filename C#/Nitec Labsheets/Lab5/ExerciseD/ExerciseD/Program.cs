using System;

namespace ExerciseD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Find maximum and minimum element in an array: \n----------------------------------------------------\nInput the number of element to be stored in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] list = new int[n];
            int max = 0;
            int min = 99999;
            Console.WriteLine($"Input {n} numbers in the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i}: ");
                list[i] = Convert.ToInt32(Console.ReadLine());
                if (list[i] > max)
                {
                    max = list[i];
                }

                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            Console.WriteLine($"The minimum element is: {min}");
            Console.WriteLine($"The maximum element is {max}");
            Console.ReadKey();
        }
    }
}
