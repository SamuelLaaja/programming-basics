using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string userAge;
            string userMtk, userArmy, userStudent;
            int age;

            // Prompt user for inputs
            Console.Write("Please enter customer's age: ");
            userAge = Console.ReadLine();

            // Check if age is a number.
            if (!int.TryParse(userAge, out age))
                Console.Write("Please write a proper number!");
            else
            {
                // Default ticket prize is 16 euros
                float prize = 16f;

                // Age related discounts.
                if (age <= 15)
                {
                    prize = prize * 0.5f;

                    if (age < 7)
                        prize = 0f;
                }
                else if (age >= 65)
                {
                    prize = prize * 0.5f;
                }
                // Membership discounts
                else
                {

                    // Prompt user for more input
                    Console.Write("Army enlisted? (y/n): ");
                    userArmy = Console.ReadLine();

                    if (userArmy == "y" || userArmy == "yes")
                    {
                        prize = prize * 0.5f;
                    }
                    else
                    {
                        // Prompt user for more input
                        Console.Write("Member of Mtk? (y/n): ");
                        userMtk = Console.ReadLine();

                        if (userMtk == "y" || userMtk == "yes")
                        {
                            prize = prize * 0.85f;
                        }

                        // Prompt user for more input
                        Console.Write("Student? (y/n): ");
                        userStudent = Console.ReadLine();

                        if (userStudent == "y" || userStudent == "yes")
                        {
                            prize = prize * 0.55f;
                        }

                    }

                }

                // Output prize with possible discounts
                Console.WriteLine("Here is your ticket prize: " + prize + " euros");
                Console.WriteLine("Have a nice day~");
            }
            // Wait for user input to end program.
            Console.ReadKey();
        }
    }
}
