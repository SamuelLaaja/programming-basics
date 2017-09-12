using System;

namespace Task3
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

            // One way to insert a variable into a string.
            Console.WriteLine("User input was: string: {0} integer: {1}", userInput, evaluatedNumber);

            // Often used for debug waiting purposes (!)
            Console.ReadKey();

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




                // When input is greater than zero
                if (evaluatedNumber > 0)
                    // The alternative way to do var-to-string insert
                    Console.Write("Number " + evaluatedNumber + " is positive.");

                // When less than zero
                else if (evaluatedNumber < 0)
                    Console.Write("Number {0} is negative.", evaluatedNumber);

                // And when equals to zero
                else
                    Console.Write("Number {0} is zero.", evaluatedNumber);

            }
            // Wait for user input to end program.
            Console.ReadKey();
        }
    }
}


    