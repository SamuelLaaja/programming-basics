using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input and convert it to upper case
            Console.WriteLine("Please write a line:");
            string line = Console.ReadLine().ToUpper();

            Console.WriteLine("Which character would you like to count?");
            // Convert the user input to upper case and take the first character from it
            char chr = Console.ReadLine().ToUpper()[0];

            // Compare characters one by one and keep count of matches
            int count = 0;
            for (int i = 0; i < line.Length; i++) {
                if (line[i] == chr)
                    count++; 
            }
            Console.WriteLine("Your line {0} has character {1} {2} times.", line, chr, count);
    
            //Wait for user input before closing program
            Console.ReadKey();
        }

    }

}
