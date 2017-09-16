using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input
            Console.WriteLine("Please write a line:");
            string line = Console.ReadLine();
            Console.WriteLine("Your line has {0} characters.", line.Length);

            //Wait for user input before closing program
            Console.ReadKey();
        }

    }

}
