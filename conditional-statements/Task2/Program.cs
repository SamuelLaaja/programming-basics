using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.Write("Please enter a number: ");

            // Read user input
            string userInput; // string variable
            userInput = Console.ReadLine();

            // Evaluate user input
            int evaluatedNumber;
            bool isNumber;
            isNumber = int.TryParse(userInput, out evaluatedNumber);

            // Check if input is actually a number.
            if (!isNumber)
                Console.Write(userInput + " is not a number!");
            else
            {
                // When input is an even number
                if (evaluatedNumber % 2 == 0)
                    Console.Write("Number " + evaluatedNumber + " is even.");
                
                // When input number is odd
                else
                    Console.Write("Number {0} is odd.", evaluatedNumber);
            }
            // Wait for user input to end program.
            Console.ReadKey();
        }
    }
}
