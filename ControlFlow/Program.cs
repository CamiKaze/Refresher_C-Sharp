using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            var sum = 0;
            while (true)
            {

                System.Console.WriteLine("Please enter a number.");
                var check = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(check))
                {
                    var temp = Convert.ToInt32(check);
                    sum += temp;
                    System.Console.WriteLine("Sum: " + sum);
                    continue;
                }
                break;
            }
        }
    }
}
