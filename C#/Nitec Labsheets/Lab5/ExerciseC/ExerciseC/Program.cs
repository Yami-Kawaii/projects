using System;

namespace ExerciseC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read n value of values in an array and display it in reverse order:");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Input the number of element to store in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] list = new string[n];
            string[] backward = new string[n];
            Console.WriteLine($"Input {n} numbers in the array:");
            for (int i = 0;i < n; i++)
            {
                Console.Write($"element - {i}: ");
                list[i] = Console.ReadLine();
                backward[n - i-1] = list[i];

            }

            string s1 = string.Join(" ", list);
            string s2 = string.Join(" ", backward);

            Console.WriteLine($"\nThe values store into an array is: {s1}\n");
            Console.WriteLine($"The value stores into the array in reverse is: {s2}\n");

            Console.ReadKey();

        }
    }
}
