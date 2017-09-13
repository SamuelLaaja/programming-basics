using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            // From 1x1 to 9x9 output multiplication table with recursive for loops
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(i + " x " + j + " = " + i*j + "   ");
                }
                Console.WriteLine();
            }
            // Wait for user input to close program
            Console.ReadKey();

        }

    }
}
