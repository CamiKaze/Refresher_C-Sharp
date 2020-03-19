using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {

            // DATETIME
            var dateTime = new DateTime(2015, 1, 10);
            var now = DateTime.Now;
            var today = DateTime.Today;

            System.Console.WriteLine("Hour: " + now.Hour);
            System.Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            System.Console.WriteLine(now.ToLongDateString());
            System.Console.WriteLine(now.ToShortDateString());
            System.Console.WriteLine(now.ToLongTimeString());
            System.Console.WriteLine(now.ToShortTimeString());
            System.Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            // TIMESPAN
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            System.Console.WriteLine("Duration: " + duration);

            // Properties of TimeSpan
            System.Console.WriteLine("Minutes: " + timeSpan.Minutes);
            System.Console.WriteLine("Total Minute: " + timeSpan.TotalMinutes);

            // Add and Subtract on TimeSpan
            System.Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            System.Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            System.Console.WriteLine("ToString" + timeSpan.ToString());

            // Parse
            System.Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
