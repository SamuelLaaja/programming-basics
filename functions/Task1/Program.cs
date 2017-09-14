using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {


            int amount;

            // Prompt user for input
            Console.Write("Please give me a number: ");
            string userAmount = Console.ReadLine();

            // Check if input is a number.
            if (!int.TryParse(userAmount, out amount))
                Console.Write("Please write a proper number!");
            else
            {
                // Make a new instance of Program Class and call method Stars()
                Program prog = new Program();
                Console.WriteLine(prog.Stars(amount));
            }
            //Wait for user input before closing program
            Console.ReadKey();
        }

        // Method Stars expects an integer value
        string Stars(int numberOfStars)
        {
            string starAmount;
            string starChars = "";

            // Negative amount is not accepted
            if (numberOfStars < 0)
                starAmount = String.Format("Number {0} is not allowed.", numberOfStars);
            else
            {
                // Keeps adding * characters into the string until input amount is reached
                for (int i = 0; i < numberOfStars; i++)
                {
                    starChars += "*";
                }

                // Format string nicely before returning it from method call
                starAmount = String.Format("I give you {0}'s worth of stars! \n{1}", numberOfStars, starChars);
            }
            return starAmount;
        }
    }
    
}
