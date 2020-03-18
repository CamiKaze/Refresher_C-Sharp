using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 6, 3, 45, 6, 7 };

            // Length
            System.Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 6);
            System.Console.WriteLine("Index of 3: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);
            System.Console.WriteLine("Clear method");
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }

            // Copy()
            int[] newArray = new int[3];
            Array.Copy(numbers, newArray, 3);
            System.Console.WriteLine("Copy method");
            foreach (var n in newArray)
            {
                System.Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);
            System.Console.WriteLine("Sort method");
            foreach(var n in numbers)
            {
                System.Console.WriteLine(n);
            }

            // Reverse Method
            Array.Reverse(numbers);
            System.Console.WriteLine("Reverse method");
            foreach(var n in numbers)
            {
                System.Console.WriteLine(n);
            }
        }
    }
}
