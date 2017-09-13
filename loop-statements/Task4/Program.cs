using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for a number
            Console.Write("Please enter a number: ");

            // Read user input
            string userInput = Console.ReadLine();
            int n, i, r;

            // Ensure input is a number
            if (!int.TryParse(userInput, out n))
            {
                Console.WriteLine("Please enter a proper number!");
            }
            else
            {
                if (n < 0)
                {
                    // Negative N!

                    // Reset ints
                    r = 0;
                    i = n;

                    //Calculate N! with while loop just for practice
                    while (i < 0)
                    {
                        r += i;
                        i++;
                    }
                    Console.WriteLine("(Negative) Result is: " + r);

                }
                else
                {
                    r = 0;
                    // Calculate N!
                    for (i = n; i >= 0; i--)
                    {
                        r += i;
                    }
                    Console.WriteLine("(Positive) Result is: " + r);

                }


            }

            // Wait for user input to close program
            Console.ReadKey();
        }
    }
}
