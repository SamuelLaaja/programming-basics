using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            // String variables
            string userInput1, userInput2, userInput3;

            // Prompt user for inputs
            Console.WriteLine("Please enter three numbers.");

            Console.Write("First number: ");
            userInput1 = Console.ReadLine();

            Console.Write("Second number: ");
            userInput2 = Console.ReadLine();

            Console.Write("Third number: ");
            userInput3 = Console.ReadLine();


            // Evaluated input variables
            int Number1, Number2, Number3;
            bool isNumber1, isNumber2, isNumber3;

            // Evaluate user inputs
            isNumber1 = int.TryParse(userInput1, out Number1);
            isNumber2 = int.TryParse(userInput2, out Number2);
            isNumber3 = int.TryParse(userInput3, out Number3);
            

            // Check if inputs are actually Numbers.
            if (!isNumber1 || !isNumber2 || !isNumber3)
                Console.Write("Please write proper numbers!");
            else
            {
                // Sort Numbers into a rising order
                Console.WriteLine("Here are your numbers represented in a nice and orderly fashion!");

                if (Number1 < Number2)
                {
                    if (Number2 < Number3)
                        Console.Write("{0},{1},{2}", Number1, Number2, Number3);
                    else if (Number1 < Number3)
                        Console.Write("{0},{1},{2}", Number1, Number3, Number2);
                    else
                        Console.Write("{0},{1},{2}", Number3, Number1, Number2);
                }

                else if (Number2 < Number3)
                {
                    if (Number1 < Number3)
                        Console.Write("{0},{1},{2}", Number2, Number1, Number3);
                    else
                        Console.Write("{0},{1},{2}", Number2, Number3, Number1);
                }

                else
                {
                    if (Number1 < Number2)
                        Console.Write("{0},{1},{2}", Number3, Number1, Number2);
                    else
                        Console.Write("{0},{1},{2}", Number3, Number2, Number1);
                }


            }
            // Wait for user input to end program.
            Console.ReadKey();
        }
    }
}
