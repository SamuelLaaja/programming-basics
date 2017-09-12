using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.Write("Please enter a number: ");

            // string variable
            string userInput; 
            // Read user input
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
                // Create a string about odd/even status and insert it to final output string.
                string oddEvenString;

                // When input is an even number
                if (evaluatedNumber % 2 == 0)
                    oddEvenString = "even";

                // When input number is odd
                else
                    oddEvenString = ("odd");

                

                // When input is greater than zero
                if (evaluatedNumber > 0)
                    Console.Write("Number {0} is positive and {1}.", evaluatedNumber, oddEvenString);

                // When less than zero
                else if (evaluatedNumber < 0)
                    Console.Write("Number {0} is negative and {1}.", evaluatedNumber, oddEvenString);

                // And when equals to zero
                else
                    Console.Write("Number {0} is zero and {1}.", evaluatedNumber, oddEvenString);

            }
            // Wait for user input to end program.
            Console.ReadKey();
        }
    }
}


    