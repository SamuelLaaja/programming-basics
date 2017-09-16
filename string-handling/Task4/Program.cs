using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user for input and convert it to upper case
            Console.WriteLine("Please write a palindrome:");
            string line = Console.ReadLine();
            string upperLine = line.ToUpper();
            // Initiate same sized character array
            char[] charLine = new char[upperLine.Length];
            
            // Remove spaces and punctuation marks from user line
            int i;
            // cleanedLength is used to track the lenght of cleaned up line
            int cleanedLength = 0;
            for (i=0; i < upperLine.Length; i++)
            {
                if (Char.IsLetterOrDigit(upperLine[i]))
                    charLine[cleanedLength++] = upperLine[i];
            }

            // Compare characters one by one. First one is supposed to match the last one and so on.
            bool isPalindrome = true;
            i = 0;
            // Test only up to half of array length
            while (isPalindrome && i < cleanedLength/2)
            {
                //break out of loop if mismatch is found
                if (charLine[i] != charLine[cleanedLength - 1 - i])
                    isPalindrome = false;
                i++;
            }
            
            // Tell if the user line is a valid palindrome or not. Uses string formatted boolean as part of text just for fun
            Console.WriteLine("Your line '{0}' is a {1} palindrome.", line, isPalindrome.ToString().ToLower() );

            //Wait for user input before closing program
            Console.ReadKey();
        }

    }

}
