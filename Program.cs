using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int low, high;

            // Get a valid positive low number from the user
            do
            {
                low = GetIntegerInput("Enter a positive low number: ");
                if (low <= 0)
                {
                    Console.WriteLine("Low number must be positive.");
                }
            } while (low <= 0);

            // Get a valid high number greater than the low number from the user
            do
            {
                high = GetIntegerInput("Enter a high number greater than the low number: ");
                if (high <= low)
                {
                    Console.WriteLine("High number must be greater than the low number.");
                }
            } while (high <= low);

            // Calculate the difference between low and high
            int difference = high - low;

            // Print out the difference
            Console.WriteLine($"The difference between {low} and {high} is: {difference}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }

        // Method to get integer input from the user with validation
        static int GetIntegerInput(string prompt)
        {
            int userInput;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
    }
}
