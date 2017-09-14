using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2;

            // Prompt user for input
            Console.Write("Please give the first number: ");
            string userNumber1 = Console.ReadLine();
            Console.Write("Please give the second number: ");
            string userNumber2 = Console.ReadLine();

            // Check if inputs are numbers.
            if (!float.TryParse(userNumber1, out number1) || !float.TryParse(userNumber2, out number2))
                Console.Write("Please write proper numbers!");
            else
            {
                Console.Write("Here is the smaller of the two numbers: ");
                // Make a new instance of Program Class and call method
                Program prog = new Program();
                Console.WriteLine(prog.Minimum(number1, number2));
            }
            //Wait for user input before closing program
            Console.ReadKey();
        }

        // Returns smaller of the two inputs
        float Minimum(float x, float y)
        {
            if (x < y)
                return x;
            else
                return y;
        }
    }

}
