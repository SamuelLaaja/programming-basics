using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string userThrows;
            int throws;
            Random rand = new Random();

            //ask user for number of coin throws
            Console.Write("How many coin throws? ");
            userThrows = Console.ReadLine();

            // Check if input is a number.
            if (!int.TryParse(userThrows, out throws))
                Console.Write("Please write a proper number!");
            else
            {
                // Ensure positive amount of coin throws
                if (throws > 0)
                {
                    int heads = 0, tails = 0;
                    Console.WriteLine("Coins are thrown for {0} times.", throws);

                    //while loop for throws
                    while (throws > 0)
                    {
                        if (rand.NextDouble() < 0.5f)
                            heads++;
                        else
                            tails++;

                        // Decrease amount of throws left
                        throws--;
                    }
                    // Successful final output
                    Console.WriteLine("Heads: {0} Tails: {1}", heads,tails);
                }
                else
                    Console.WriteLine("Please give a number greater than zero!");
            }

            // Wait for user input to close program
            Console.ReadKey();
        }
    }
}
