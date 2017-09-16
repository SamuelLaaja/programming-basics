using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input
            Console.WriteLine("Please write a line:");
            string line = Console.ReadLine();
            Console.WriteLine("Here is your line with letters 'e' replaced with '@': ");
            Console.WriteLine(line.Replace('e','@'));

            //Wait for user input before closing program
            Console.ReadKey();
        }

    }

}
