using System;

namespace Iteration
{
    class Program
    {
        // Iterating through a loop
        private static void IncrementForLoop()
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        // Iterating through a loop
        private static void DecrementForLoop()
        {
            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        // Iterating through a loop and listing the characters
        private static void IterateString()
        {
            var name = "Cameron Smith";

            foreach (var character in name)
            {
                System.Console.WriteLine(character);
            }
        }

        // Iterating through an array of numbers
        private static void IterateArray()
        {
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }
        // Displaying a value from user input
        private static void WhileConditionNotMet()
        {
            while (true)
            {
                System.Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Increment Loop");
            IncrementForLoop();

            System.Console.WriteLine("Decrement Loop");
            DecrementForLoop();

            System.Console.WriteLine("Loop over characters in string");
            IterateString();

            System.Console.WriteLine("Loop over index in array");
            IterateArray();

            System.Console.WriteLine("While a condition has not been met");
            WhileConditionNotMet();
        }
    }
}
