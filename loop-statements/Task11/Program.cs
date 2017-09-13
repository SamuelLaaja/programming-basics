using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {

            //start counting from 1, also counter for sixes
            int i = 1, six = 0;
            Random rand = new Random();

            //while loop for 1000 times of dice throwing
            while (i <= 1000)
            {
                // Random between 1-6.
                int x = rand.Next(1,7);
                
                // Output dice
                Console.WriteLine(i + ". " + x);
                // Keep count of sixes
                if (x == 6)
                    six++;
                // Decrease amount of dice throws left
                i++;
            }
            Console.WriteLine("Number six appeared {0} times.", six);

            // Wait for user input to close program
            Console.ReadKey();
        }
    }
}
