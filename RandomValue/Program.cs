using System;

namespace RandomValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                System.Console.WriteLine(random.Next(1, 10));
            }

const int paswwordLength = 10;
            var buffer = new char[paswwordLength];

            for (var i = 0; i < paswwordLength; i++)
                buffer[i] = ((char)('a' + random.Next(0, 26)));
            var password = new string(buffer);

            System.Console.WriteLine($"Password: {password}");
        }
    }
}
