using System;

namespace ConditionalStatements
{
    class Program
    {

        // If statements for seasons
        private static void TimeOfDay()
        {
            int hour = 10;

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
        }

        // Switch statement for seasons
        private static void IfStatementTernary()
        {
            var isGoldCustomer = true;
            var price = (isGoldCustomer) ? 19.95f : 29.95f;

            System.Console.WriteLine(price);
        }
        private static void SeasonalSwitch()
        {
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

        // Check if user input is between 1 and 10
        private static void NumberValidity()
        {
            System.Console.WriteLine("Please enter a number between 1 and 10.");
            var userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput < 10 && userInput > 1)
            {
                System.Console.WriteLine($"Valid: The entered value is {userInput}");
            }
            else
            {
                System.Console.WriteLine("Invalid: User input must be between 1 and 10");
            }
        }
        // Find the maximum value between two user inputs
        private static void UserInputMax()
        {
            System.Console.WriteLine("Addition: Please enter the first number");
            var firstValue = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Addition: Please enter the second number");
            var secondValue = Convert.ToInt32(Console.ReadLine());

            var maxValue = (firstValue > secondValue) ? firstValue : secondValue;

            System.Console.WriteLine($"The Max of the two numbers are: {maxValue}");
        }
        // Check image orientation between two user values
        private static void PortraitLandscapeSelection()
        {
            System.Console.WriteLine("Please enter the width for your picture frame.");
            var width = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Please enter the height for your picture frame.");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;

            System.Console.WriteLine($"Image orientation is {orientation}");
        }
        // Check the speed of a vehicle and penalise if user went above the threshold
        private static void SpeedTest()
        {
            System.Console.WriteLine("What is the speed limit?");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("What was the speed of the car?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                System.Console.WriteLine("OK");
            }
            else if (carSpeed > speedLimit)
            {
                var demeritTotal = carSpeed - speedLimit;
                var demeritPoints = demeritTotal / 5;

                if (demeritPoints > 12)
                {
                    System.Console.WriteLine("License Suspended");
                }
                else
                {
                    System.Console.WriteLine($"{demeritPoints} Demerit points incurred");
                }
            }
        }

        static void Main(string[] args)
        {
            // If statements.
            TimeOfDay();

            // Conditional statement - Ternary.
            IfStatementTernary();

            // Switch statement.
            SeasonalSwitch();

            /// <summary>
            /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            /// applications where values entered into input boxes need to be validated.)
            /// </summary>
            NumberValidity();

            /// <summary>
            /// Write a program which takes two numbers from the console and displays the maximum of the two.
            /// </summary>
            UserInputMax();

            /// <summary>
            /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            /// is landscape or portrait.
            /// </summary>
            PortraitLandscapeSelection();

            /// <summary>
            /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            /// the console. If the number of demerit points is above 12, the program should display License Suspended.
            /// </summary>
            SpeedTest();
        }
    }
}
