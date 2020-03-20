using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*When you post a message on Facebook, depending on the number of people who like your post,
            Facebook displays different information.
            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
            Depending on the number of names provided, display a message based on the above pattern.*/
            var list = new List<Tuple<string, string>>();
            var likedUsers = new List<string>();
            var count = 0;

            while (true)
            {
                System.Console.WriteLine("Please enter a name from Facebook");
                var name = Console.ReadLine();

                System.Console.WriteLine("Do you like the Post? \"Yes/No\"");
                var like = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(name))
                {
                    list.Add(new Tuple<string, string>(name, like));

                    continue;
                }
                break;
            }

            foreach (var tuple in list)
            {
                if (tuple.Item2 == "Yes")

                {
                    likedUsers.Add(tuple.Item1);
                    count++;
                }
            }

            switch (count)
            {
                case (1):
                    System.Console.WriteLine("{0} liked your post.",
                        likedUsers[0]);
                    break;
                case (2):
                    System.Console.WriteLine("{0} and {1} liked your post.",
                        likedUsers[0], likedUsers[1]);
                    break;
                default:
                    System.Console.WriteLine("{0}, {1}, and {2} other people liked your post.",
                        likedUsers[0], likedUsers[1], count - 2);
                    break;
            }

            /* Write a program and ask the user to enter their name. Use an array to
            reverse the name and then store the result in a new string. Display the
             reversed name on the console. */
            System.Console.WriteLine("Please enter a name");
            var username = Console.ReadLine();
            var charName = username.ToCharArray();

            Array.Reverse(charName);
            string result = new string(charName);

            System.Console.WriteLine(result);

            /*Write a program and ask the user to enter 5 numbers. If a number has been previously entered,
            display an error message and ask the user to re-try. Once the user successfully enters 5 unique
            numbers, sort them and display the result on the console.*/
            int i = 0;
            var uniqueNumbers = new List<int>();

            while (i < 5)
            {
                System.Console.WriteLine("Please enter a number");
                var uniqueNumber = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(uniqueNumber))
                {
                    uniqueNumbers.Add(Convert.ToInt32(uniqueNumber));
                    i++;
                    continue;
                }
                break;
            }

            bool isUnique = uniqueNumbers.Distinct().Count() == uniqueNumbers.Count();

            uniqueNumbers.Sort();

            if (isUnique == true)
                uniqueNumbers.ForEach(Console.WriteLine);
            else
                System.Console.WriteLine($"{isUnique}: The numbers entere is not unique. Please try again");

            /*Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            The list of numbers may include duplicates. Display the unique numbers that the user has entered*/
            int j = 0;
            var displayUniqueNumbers = new List<int>();

            while (j < 5)
            {
                System.Console.WriteLine("Please enter a number");
                var enteredNumbers = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(enteredNumbers))
                {
                    displayUniqueNumbers.Add(Convert.ToInt32(enteredNumbers));
                    i++;
                    continue;
                }
                break;
            }
            System.Console.WriteLine(displayUniqueNumbers.Distinct());
        }
    }
}
