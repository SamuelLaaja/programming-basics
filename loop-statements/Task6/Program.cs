using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explanations
            Console.WriteLine("Number Squareroot");

            // From 1 to 10 output number and rounded square root
            for (int i = 1; i <= 10; i++)
            Console.WriteLine(i + "       " + Math.Round( Math.Sqrt(i),2 ));

            // Wait for user input to close program
            Console.ReadKey();

        }

    }
}
