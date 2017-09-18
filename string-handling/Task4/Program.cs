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
            // cleanedLength is used to remember the lenght of cleaned up line
            int cleanedLength = 0;
            for (i=0; i < upperLine.Length; i++)
            {
                if (Char.IsLetterOrDigit(upperLine[i]))
                    charLine[cleanedLength++] = upperLine[i];
            }

            // Set char array back to string and copy a reverse of it for later use
            string normalStringOrder = new string(charLine);
            Array.Reverse(charLine);
            string reverseStringOrder = new string(charLine);

            // Compare characters one by one. First one is supposed to match the last one and so on.
            bool isPalindrome = true;
            i = 0;

            // Test only up to half of the string length
            while (isPalindrome && i < cleanedLength/2)
            {
                //break out of loop if mismatch is found between [first & last letter], [second first & second last letter] and so on.
                if (normalStringOrder[i] != normalStringOrder[cleanedLength - 1 - i])
                    isPalindrome = false;
                i++;
            }

            // Second way:
            // Compares the string and it's reverse version
            if (normalStringOrder != reverseStringOrder)
                isPalindrome = false;
            

            // Tell if the user line is a valid palindrome or not. Uses string formatted boolean as part of text, just for fun
            Console.WriteLine("Your line '{0}' is a {1} palindrome.", line, isPalindrome.ToString().ToLower() );

            //Wait for user input before closing program
            Console.ReadKey();
        }

    }

}
