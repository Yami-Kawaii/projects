using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            Console.Write("Enter grade for first module:");
            string Grade1 = Console.ReadLine();
            switch (Grade1)
            {
                case "A":
                    total += 4;
                    break;
                case "B":
                    total += 3;
                    break;
                case "C":
                    total += 2;
                    break;
                case "D":
                    total += 1;
                    break;
            }

            Console.Write("Enter grade for second module:");
            string Grade2 = Console.ReadLine();
            switch (Grade2)
            {
                case "A":
                    total += 4;
                break;
                case "B":
                    total += 3;
                break;
                case "C":
                    total += 2;
                break;
                case "D":
                    total += 1;
                break;
            }
            Console.Write("Enter grade for third module:");
            string Grade3 = Console.ReadLine();
            switch (Grade3)
            {
                case "A":
                    total += 4;
                    break;
                case "B":
                    total += 3;
                    break;
                case "C":
                    total += 2;
                    break;
                case "D":
                    total += 1;
                    break;
            }

            Console.Write("Enter grade for fourth module:");
            string Grade4 = Console.ReadLine();
            switch (Grade4)
                {
                    case "A":
                        total += 4;
                        break;
                    case "B":
                        total += 3;
                        break;
                    case "C":
                        total += 2;
                        break;
                    case "D":
                        total += 1;
                        break;
                }
            double average = total / 4;
            Console.WriteLine(average);

            
            if (average >= 3.5)
                {
                Console.WriteLine("GPA = " + average);
                Console.WriteLine("Congratulations. You are eligible to apply 3 Year Diploma course at Polytechnic. ");
            }
            else if (average >= 3 && average < 3.5){
                Console.WriteLine("GPA = " + average);
                Console.WriteLine("Congratulations. You are eligible to apply 1 Year Higher NITEC course at ITE. ");
            }
            else if (average >= 2.4 && average < 3)
            {
                Console.WriteLine("GPA = " + average);
                Console.WriteLine("Congratulations. You are eligible to apply 2 Year Higher NITEC course at ITE. ");
            }
            else
            {
                Console.WriteLine("GPA = " + average);
                Console.WriteLine("Not eligible for higher learning. ");
            }
            Console.ReadKey();
        }
    }
}