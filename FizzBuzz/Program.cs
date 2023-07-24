using System;
using MathOperationLibraries;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press any key to continue...");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Press any key to continue...");
                return;
            }

            int number = Int32.Parse(input);

            string result;
            if (Divide.ByThree(number) && Divide.ByFive(number))
            {
                result = "FizzBuzz";
            }
            else if (Divide.ByThree(number))
            {
                result = "Fizz";
            }
            else if (Divide.ByFive(number))
            {
                result = "Buzz";
            }
            else
            {
                result = "To bad";
            }
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Result: {result}");
        }
    }
}