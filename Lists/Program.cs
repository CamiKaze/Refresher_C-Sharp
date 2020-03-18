using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add values to a list
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 1, 9 });

            // Loop through the values in a list
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            // Display values in the list
            System.Console.WriteLine();
            System.Console.WriteLine($"Index of 3 is {numbers.IndexOf(3)}");
            System.Console.WriteLine($"Last index of 1 is {numbers.LastIndexOf(1)}");

            System.Console.WriteLine("count: " + numbers.Count);

            // Removes all "1"
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            // Displays the altered list
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            // Clears the list
            numbers.Clear();

            // Dsiplays the number of elements in the list
            System.Console.WriteLine("count: " + numbers.Count);
        }
    }
}
