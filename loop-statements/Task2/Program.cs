using System;

namespace Task2
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
                if (n < 1)
                {
                    // Negative or zero results are undefinied.
                    Console.WriteLine("Result is: Undefinied.");
                }
                else
                {
                    int i, r = 0;
                    // Calculate N!
                    for (i = n; i >= 0; i--)
                    {
                        r += i;
                    }
                    Console.WriteLine("(For loop) Result is: " + r);

                    // Reset ints
                    r = 0;
                    i = n;

                    //Calculate N! with while loop just for practice
                    while (i > 0) {
                        r += i;
                        i--;
                    }
                    Console.WriteLine("(While loop) Result is: " + r);
                }


            }

            // Wait for user input to close program
            Console.ReadKey();
        }
    }
}
