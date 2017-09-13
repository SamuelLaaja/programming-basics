using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for a number
            Console.Write("Please enter a number: ");

            // Read user input
            string userInput = Console.ReadLine();
            int n;

            // Ensure input is a number
            if (!int.TryParse(userInput, out n))
            {
                Console.WriteLine("Please enter a proper number!");
            }
            else
            {
                int i, multiplier, r = 0;

                multiplier = n < 0 ? -1 : 1;

                // Calculate odd numbers of N!
                for (i = 1; i <= n * multiplier; i = i + 2)
                {
                    r += i;
                }
                Console.WriteLine("(Positive) Result of odd numbers is: " + r * multiplier);

                // Reset ints
                r = 0;
                i = 2;

                //Calculate even numbers of N! with While Loop for practice
                while (i <= n * multiplier)
                {
                    r += i;
                    i = i + 2;
                }
                Console.WriteLine("(Negative) Result of even numbers is: " + r * multiplier);
            }

            

            // Wait for user input to close program
            Console.ReadKey();
        }
    }
}
