using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine() ?? "Guest";
            Console.WriteLine($"Hello, {name}! Welcome to our app.");
            Console.ReadKey();
        }
    }
}
