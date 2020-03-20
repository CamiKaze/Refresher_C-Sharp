using System;
using System.Collections.Generic;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter their name. Use an array to
            reverse the name and then store the result in a new string. Display the
             reversed name on the console. */
            System.Console.WriteLine("Please enter a name");
            var username = Console.ReadLine().ToCharArray();
            var reversed = ReverseName(username);
            System.Console.WriteLine(username);

            var numbers = new List<int>();

            while (true)
            {
                System.Console.WriteLine("Enter a number (or 'Quit') to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            System.Console.WriteLine("Unique numbers:");
            foreach (var number in GetUniqueNumbers(numbers))
                System.Console.WriteLine(number);
        }

        public static char[] ReverseName(char[] username)
        {
            Array.Reverse(username);
            return username;
        }

        private static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            return uniques;
        }
    }
}
