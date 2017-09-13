using System;

namespace Task1
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
            if (!int.TryParse(userInput, out n)) {
                Console.WriteLine("Please enter a proper number!");
            }
            else {
                if (n < 0)
                {
                    // Negative results are undefinied.
                    Console.WriteLine("Result is: Undefinied.");
                }
                else {
                    int i, r = 1;
                    // Calculate N!
                    for (i = n; i > 0; i--) {
                        r *= i;
                    }
                    Console.WriteLine("Result is: " + r);
                }

            }

            // Wait for user input to close program
            Console.ReadKey();
        }
    }
}
