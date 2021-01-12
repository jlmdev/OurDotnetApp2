using System;

namespace OurDotnetApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Josh";
            var rightNow = DateTime.Now;
            Console.WriteLine($"Hello, {name}. Welcome to C#");
            Console.WriteLine($"Your name is {name.Length} letters long.");
            Console.WriteLine($"It's now {rightNow}.");
        }
    }
}
