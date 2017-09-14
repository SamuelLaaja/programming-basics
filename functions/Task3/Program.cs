using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2;

            // Prompt user for input
            Console.Write("Please give the lower end of range: ");
            string userNumber1 = Console.ReadLine();
            Console.Write("Please give the higher end of range: ");
            string userNumber2 = Console.ReadLine();

            // Check if inputs are numbers.
            if (!float.TryParse(userNumber1, out number1) || !float.TryParse(userNumber2, out number2))
                Console.Write("Please write proper numbers!");
            else
            {
                // Make sure numbers create a proper range. From smaller value to larger
                if (number2 < number1) {
                    Console.WriteLine("Whoops! Your numbers are in wrong order. Let me fix that for you~");
                    float temp = number1;
                    number1 = number2;
                    number2 = temp;
                }

                Console.Write("Next give a number that is between the range [{0},{1}]: ", number1, number2);
                // Make a new instance of Program Class and call method
                Program prog = new Program();
                float output = prog.InputNumberBetweenRange(number1, number2);
                Console.WriteLine("Correct! {0} is between {1} and {2}. Thank you!", output, number1, number2);
            }
            //Wait for user input before closing program
            Console.ReadKey();
        }

        // Keeps asking for a number between the two inputs
        float InputNumberBetweenRange(float x, float y)
        {
            float input;
            string userNumber = Console.ReadLine();

            // Check if inputs are numbers.
            if (!float.TryParse(userNumber, out input))
            {
                Console.Write(userNumber + " is not a proper number. Please try again: ");

                return InputNumberBetweenRange(x, y);
            }
            else if (input < x || input > y)
            {
                Console.Write(input + " is not between [{0},{1}] range. Please try again: ", x,y);

                return InputNumberBetweenRange(x, y);

            }
            else
            {
                return input;
            }
        }
    }

}
