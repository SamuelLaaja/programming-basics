using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input and convert it to upper case
            Console.WriteLine("Please write a line:");
            string line = Console.ReadLine();
            string upperLine = line.ToUpper();

            // Vowels listed in a string array for comparison purpose. Ä and Ö do not work due to Console limitation.
            // Strings are used because of possible multi-character Unicode letters, such as Ä, Ö and Å (unconfirmed).
            string[] vowels = {"A", "E", "I", "O", "U", "Y", "Ä", "Ö", "Å" };

            // Test if user line contains each vowel and keep count of vowel matches
            int count = 0;
            foreach (string v in vowels)
            {
                foreach (var c in upperLine)
                {
                    if (c.ToString() == v)
                    count++;
                }
            }
            // Output original line and wovel count
            Console.WriteLine("Your line '{0}' has {1} vowels.", line, count);

            // Wait for user input before closing program
            Console.ReadKey();
        }

    }

}
