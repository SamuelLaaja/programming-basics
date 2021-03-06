﻿using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for a number
            Console.Write("Please enter a number: ");

            // Read user input
            string userInput = Console.ReadLine();
            int n;

            // Ensure input is a number
            if (!int.TryParse(userInput, out n))
            {
                Console.WriteLine("Please enter a proper number!");
            }
            else
            {
                if (n < 1)
                {
                    // Negative or zero results are undefinied.
                    Console.WriteLine("Result is: Undefinied.");
                }
                else
                {
                    int i, r = 0;

                    // Calculate odd numbers of N!
                    for (i = 1; i <= n; i=i+2)
                    {
                        r += i;
                    }
                    Console.WriteLine("(For loop) Result of odd numbers is: " + r);

                    // Reset ints
                    r = 0;
                    i = 2;

                    //Calculate even numbers of N! with While Loop for practice
                    while (i <= n)
                    {
                        r += i;
                        i = i+2;
                    }
                    Console.WriteLine("(While loop) Result of even numbers is: " + r);
                }


            }

            // Wait for user input to close program
            Console.ReadKey();
        }
    }
}
