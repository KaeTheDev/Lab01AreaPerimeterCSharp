using System;

namespace Lab01
{
       class Lab01
    {
        static void Main(string[] args)
        {
            double length = 0.0;
            double width = 0.0;
            double area = 0.0;
            double perimeter = 0.0;
            string userInput;
       
            Console.WriteLine("Welcome to KaeTheDev's Room Detail Generator!");
            Console.WriteLine();
            do
            {
                //Asks user for length and accepts length
                Console.Write("Enter length: ");
                length = Convert.ToDouble(Console.ReadLine());

                //Asks user for width and accepts width
                Console.Write("Enter width: ");
                width = Convert.ToDouble(Console.ReadLine());

                //Calculates the area and perimeter
                area = length * width;
                perimeter = (length * 2) + (width * 2);

                //Prints calculated area and perimeter to the screen
                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);

                Console.WriteLine("Continue? (Y/N): ");
                userInput = Console.ReadLine();
            } while (userInput.Equals("Y"));

            /* Makes the program wait for a key press and it prevents the screen from running and closing quickly
             when the program is launched. */
            Console.ReadKey();

        }
    }
}