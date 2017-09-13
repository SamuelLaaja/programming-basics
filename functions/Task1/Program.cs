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

                Console.WriteLine(Stars(amount));
            }

            Console.ReadKey();
        }

        static string Stars(int numberOfStars)
        {
            string starAmount;
            string starChars = "";

            if (numberOfStars < 0)
                starAmount = String.Format("Number {0} is not allowed.", numberOfStars);
            else
            {
                for (int i = 0; i < numberOfStars; i++)
                {
                    starChars += "*";
                }

                starAmount = String.Format("I give you {0}'s worth of stars! \n{1}", numberOfStars, starChars);
            }
            return starAmount;
        }
    }
    
}
