using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if
            the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            display a message: "Consecutive"; otherwise, display "Not Consecutive".*/
            var intList = new List<int>();

            System.Console.WriteLine("Please enter 5 values separated by a hyphen. e.g. \"1-2-3-4-5\"");
            var enteredValue = Console.ReadLine();

            intList = enteredValue.Split('-').ToList().ConvertAll(int.Parse);
            intList.Sort();

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
            var isConsecutive = !intList.Select((i, j) => i - j).Distinct().Skip(1).Any();

            System.Console.WriteLine(isConsecutive);

            foreach (var val in intList)
                System.Console.WriteLine(val);

            /* Write a program and ask the user to enter a few numbers separated by a hyphen.
            If the user simply presses Enter, without supplying an input, exit immediately; otherwise,
            check to see if there are duplicates. If so, display "Duplicate" on the console. */
            var userList = new List<int>();
            System.Console.WriteLine("Please enter a list of numbers separated by a hyphen.");
            var userValues = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(userValues))
            {
                userList = userValues.Split('-').ToList().ConvertAll(int.Parse);

                if (userList.Count != userList.Distinct().Count())
                {
                    System.Console.WriteLine("Duplicates exist");
                }
            }

            /* Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
            A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display
            "Invalid Time". If the user doesn't provide any values, consider it as invalid time.*/
            System.Console.WriteLine("Please enter a time value in the 24-hour format.");
            var timeValues = Console.ReadLine();

            var hourMinute = new TimeSpan(00, 00, 00);
            var start = new TimeSpan(00, 00, 00);
            var end = new TimeSpan(23, 59, 00);

            if (!String.IsNullOrWhiteSpace(timeValues))
            {
                if ((hourMinute > start) && (hourMinute < end))
                {
                    System.Console.WriteLine("Ok " + hourMinute);
                    hourMinute = TimeSpan.Parse(timeValues);
                }
                else
                    System.Console.WriteLine("Invalid Time");
            }

            /*Write a program and ask the user to enter a few words separated by a space. Use the words to create a
            variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".
            Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS",
            the program should still display "NumberOfStudents".*/
            System.Console.WriteLine("Please write a sentence.");
            var userSentence = Console.ReadLine().ToLower().Split(' ').ToList();
            StringBuilder PascalCase = new StringBuilder();
            string Cap = null;

            for (int i = 0; i < userSentence.Count; i++)
            {
                Cap = userSentence[i];
                PascalCase.Append(char.ToUpper(Cap[0]) + Cap.Substring(1));
            }

            System.Console.WriteLine(PascalCase);

            /* Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
            So, if the user enters "inadequate", the program should display 6 on the console. */

            System.Console.WriteLine("Please write a Word.");
            var englishWord = Console.ReadLine().ToLower();
            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            var count = 0;

            foreach (var character in englishWord)
            {
                if (vowels.Contains(character))
                    count++;
            }

            System.Console.WriteLine(count);

        }
    }
}
