using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first #:  ");
            double a = int.Parse(Console.ReadLine());

            Console.Write("Please enter your second #:  ");
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick your operation: Add | Subtract | Multiply | Divide | Remainder ");
            string Operation = Console.ReadLine().ToLower();

            if (Operation == "add" || Operation == "+")
            {
                Console.WriteLine($"{a + b}");
            }

            else if (Operation == "subtract" || Operation == "-")
            {
                Console.WriteLine($"{a - b}");
            }

            else if (Operation == "multiply" || Operation == "*")
            {
                Console.WriteLine($"{a * b}");
            }

            else if (Operation == "divide" || Operation == "/")
            {
                Console.WriteLine($"{a / b}");
            }

            else if (Operation == "remainder" || Operation == "5")
            {
                Console.WriteLine($"{a % b}");
            }

            else
            {
                Console.WriteLine("I'm sorry. I don't know how to do that.");
            }

        }
    }
}
