using System;
using System.Collections.Generic;
using System.Linq;

namespace TextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if
            the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            display a message: "Consecutive"; otherwise, display "Not Consecutive".*/
            var strList = new List<string>();
            var intList = new List<int>();

            System.Console.WriteLine("Please enter 5 values separated by a hyphen. e.g. \"1-2-3-4-5\"");
            var enteredValue = Console.ReadLine();

            intList = enteredValue.Split('-').ToList().ConvertAll(int.Parse);
            intList.Sort();

            var isConsecutive = !intList.Select((i, j) => i - j).Distinct().Skip(1).Any();

            System.Console.WriteLine(isConsecutive);

            foreach (var val in intList)
                System.Console.WriteLine(val);

            /*Input is { 5, 6, 7, 8 }
            Select yields { (5-0=)5, (6-1=)5, (7-2=)5, (8-3=)5 }
            Distinct yields { 5, (5 not distinct, 5 not distinct, 5 not distinct) }
            Skip yields { (5 skipped, nothing left) }
            Any returns false
            Input is { 1, 2, 6, 7 }
            Select yields { (1-0=)1, (2-1=)1, (6-2=)4, (7-3=)4 } *
            Distinct yields { 1, (1 not distinct,) 4, (4 not distinct) } *
            Skip yields { (1 skipped,) 4 }
            Any returns true*/
        }
    }
}
