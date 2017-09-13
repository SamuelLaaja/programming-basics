using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {

            //start marks from 1
            int i = 1;
            Random rand = new Random();

            //while loop for 13 marks
            while (i <= 13)
            {
                // Random between 0-1
                double x = rand.NextDouble();
                // Output defaults to X (even)
                string s = "X";

                // Probability for home win
                if (x <= 0.4f)
                    s = "1";
                // Probability for home loss
                else if (x >= 0.6f)
                    s = "2";

                // Output mark
                Console.WriteLine(i + ". " + s);
                // Decrease amount of marks left
                i++;
            }

            // Wait for user input to close program
            Console.ReadKey();
        }
    }
}
