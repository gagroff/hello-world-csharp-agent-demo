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

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Calculator Menu ===");
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Subtract two numbers");
                Console.WriteLine("3. Multiply two numbers");
                Console.WriteLine("4. Divide two numbers");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");

                string choice = Console.ReadLine() ?? "";

                if (choice == "5")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("Invalid option. Please select 1-5.");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Enter the first number: ");
                string input1 = Console.ReadLine() ?? "";
                Console.Write("Enter the second number: ");
                string input2 = Console.ReadLine() ?? "";

                if (!double.TryParse(input1, out double num1) || !double.TryParse(input2, out double num2))
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    double result;
                    string operation;

                    switch (choice)
                    {
                        case "1":
                            result = num1 + num2;
                            operation = "+";
                            break;
                        case "2":
                            result = num1 - num2;
                            operation = "-";
                            break;
                        case "3":
                            result = num1 * num2;
                            operation = "*";
                            break;
                        default:
                            if (num2 == 0)
                                throw new DivideByZeroException("Cannot divide by zero.");
                            result = num1 / num2;
                            operation = "/";
                            break;
                    }

                    Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.ReadKey();
            }
        }
    }
}
