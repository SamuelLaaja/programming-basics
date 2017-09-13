using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();
            int randomNumber;

            // Row loop from 1 to 4
            for (int i = 1; i <= 4; i++)
            {
                // For each row, output 5 random numbers
                Console.Write("Row " + i + ": ");
                for (int j = 1; j <= 5; j++)
                {
                    // Random number is stored in r.
                    randomNumber = rand.Next(51);
                    // Ternary Conditional Operator ?: used for whitespace clean-up for numbers less than 10 and comma / newline switch
                    Console.Write( (randomNumber > 10 ? "" : " ") + randomNumber + (j < 5 ? ", ": "\n") );

                }

            }
            // Wait for user input to close program
            Console.ReadKey();

        }

    }
}
