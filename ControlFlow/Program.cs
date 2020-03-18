using System;
namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program to count how many numbers between 1 and 100 are
            divisible by 3 with no remainder. Display the count on the console.*/
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            System.Console.WriteLine($"There are {count} numbers that are divisible by 3 between 1 and 100");

            /*Write a program and continuously ask the user to enter a number or "ok"
            to exit. Calculate the sum of all the previously entered numbers and
            display it on the console.*/
            var sum = 0;
            while (true)
            {
                System.Console.WriteLine("Please enter a number.");
                var check = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(check))
                {
                    var temp = Convert.ToInt32(check);
                    sum += temp;
                    continue;
                }
                System.Console.WriteLine($"The sum of all entered values are {sum}");
                break;
            }

            /*Write a program and ask the user to enter a number. Compute the factorial
            of the number and print it on the console. For example, if the user enters 5,
            the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/
            System.Console.WriteLine("Please enter a number for factorial calculation.");
            var userNumber = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;

            for (var i = 1; i <= userNumber; i++)
            {
                factorial *= i;

            }
            System.Console.WriteLine($"The factorial for {userNumber}! is {factorial}");

            /*Write a program that picks a random number between 1 and 10. Give the user 4
            chances to guess the number. If the user guesses the number, display “You won";
            otherwise, display “You lost". (To make sure the program is behaving correctly,
            you can display the secret number on the console first.)*/
            var rand = new Random();
            int randNumber = rand.Next(1, 10);
            var chances = 4;

            for (int i = 1; i <= chances; i++)
            {
                System.Console.WriteLine("Please guess a random number between one and ten. You have four attempts");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randNumber)
                {
                    System.Console.WriteLine("You won");
                    break;
                }
                else
                    System.Console.WriteLine("You lost");
            }

            /*Write a program and ask the user to enter a series of numbers separated by comma.
            Find the maximum of the numbers and display it on the console. For example, if the
            user enters “5, 3, 8, 1, 4", the program should display 8.*/
            System.Console.WriteLine("Please enter a series of number separted by a comma.");
            string[] stringOfNumbers = Console.ReadLine().Split(",");

            int maxNumber = Convert.ToInt32(stringOfNumbers[0]);

            foreach (var str in stringOfNumbers)
            {
                var number = Convert.ToInt32(str);

                if (maxNumber < number)
                {
                    maxNumber = number;
                }
            }

            System.Console.WriteLine($"{maxNumber} is the maximun number in the array");
        }
    }
}
