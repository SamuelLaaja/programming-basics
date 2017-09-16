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
            
            // Negative amount is not accepted
            if (numberOfStars < 0)
                starAmount = String.Format("Number {0} is not allowed.", numberOfStars);
            else
            {
                // A new string is initiated with the length of numberOfStars and filled with * chars 
                // This way minimizes the amount of garbage memory compared to manually filling a string with *:s
                string str = new string('*', numberOfStars);

                // Format string nicely before returning it from method call
                starAmount = String.Format("I give you {0}'s worth of stars! \n{1}", numberOfStars, str);
            }
            return starAmount;
        }
    }
    
}
