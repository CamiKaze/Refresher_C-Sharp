using System;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Cameron Smith ";
            System.Console.WriteLine("Trim: '{0}'", fullName.Trim());
            System.Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            // Not a good approach
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            System.Console.WriteLine("FirstName: " + firstName);
            System.Console.WriteLine("LastName: " + lastName);

            // Better approach
            var names = fullName.Split(' ');
            System.Console.WriteLine("FirstName: " + names[0]);
            System.Console.WriteLine("LastName: " + names[1]);

            // Replace Method
            System.Console.WriteLine(fullName.Replace("Cameron", "Cammy"));

            // Validation
            if (String.IsNullOrWhiteSpace(" "))
                System.Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            System.Console.WriteLine(age);

            float price = 29.95f;
            System.Console.WriteLine(price.ToString("C0"));

            var sentence = "This is going to be a really really really really really really really really really long text";
            var summary = StringUtility.SummarizeText(sentence, 25);
            System.Console.WriteLine(summary);
        }
    }
}
