using System;

namespace takeme
{
    class Pencil
    {

        public string color;
        public string size;

        public void Writing(string color, string size)
        {
            Console.WriteLine($"Currently coloring with a {color} pencil and size {size}");
    
    }

        public void Breaking(string color, string size)
        {
            Console.WriteLine($"Currently brekaing a {color} pencil and size {size}");


    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
