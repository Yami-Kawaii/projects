using System;

namespace Raining
{
    class Program
    {
        public static string RainCheck(string value)
        {
            string str = "";
            if (value == "Yes" || value == "yes")
            {
                str = "Don't come to school!";
            }
            else if (value == "No" || value == "no"){
                str = "Come to school!";
            }

            return str;
        }

        static void Main(string[] args)
        {
            Console.Write("Is it raining: ");
            string ans = Console.ReadLine();
            Console.WriteLine(RainCheck(ans));


            Console.ReadKey();
        }

    }
}
