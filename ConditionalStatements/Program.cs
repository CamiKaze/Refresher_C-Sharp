using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            // If statements
            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                System.Console.WriteLine("It's afternoon.");
            }
            else
            {
                System.Console.WriteLine("It's evening.");
            }

            // Conditional statement - Ternary
            bool isGoldCustomer = true;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            System.Console.WriteLine(price);

            // Switch statement
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    System.Console.WriteLine("We've got a promotion");
                    break;

                default:
                    System.Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
