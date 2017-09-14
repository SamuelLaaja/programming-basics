using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input
            Console.WriteLine("Please give ten non-negative whole numbers:");
            
            // Make a new instance of Program Class and call method
            Program prog = new Program();
            string output = prog.InputNumbers();
            Console.WriteLine(output);

            //Wait for user input before closing program
            Console.ReadKey();
        }


        // Keeps asking for numbers until 10, returns the biggest of them as a string
        string InputNumbers()
        {
            // Uses array for input numbers
            int[] numbers = new int[10];
            string userNumber;
            int counter = 0, max = 0;

            while (counter < 10) {

                // Tells user which number we are currently at
                Console.Write((counter + 1) + ". ");
                userNumber = Console.ReadLine();

                // Check if input is a valid number.
                if (!int.TryParse(userNumber, out numbers[counter]))
                {
                    Console.WriteLine(userNumber + " is not a proper number. Please try again: ");

                }
                // Check if input is a positive number
                else if (numbers[counter] < 0)
                {
                    Console.WriteLine(numbers[counter] + " is not a positive number. Please try again: ");

                }
                // Number is accepted!
                else {
                    // Keep track of which array position holds the maximum number
                    if (numbers[counter] > numbers[max])
                        max = counter;

                    // Move on to next input number!
                    counter++;
                }

            }
            // Summarize accepted input numbers separated with commas (except the last one)
            Console.WriteLine("You gave the following numbers: ");
            for (counter = 0; counter < 10; counter++)
            {
                if (counter != 9)
                Console.Write(numbers[counter] + ", ");
                else
                Console.WriteLine(numbers[counter]);
            }

            // Returns nicely formatted string for the main program
            return String.Format("Biggest of them was {0}. number, which was {1}.", (max+1), numbers[max]);

        }
    }

}
