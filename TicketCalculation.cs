using System;

namespace MovieTicketCalculator
{
    // Class to handle age-based ticket pricing
    class AgeBasedPricing
    {
        // Properties for ticket prices
        public double RegularPrice { get; private set; } = 10.0;
        public double DiscountedPrice { get; private set; } = 7.0;

        // Method to calculate ticket price based on age
        public double CalculatePrice(int customerAge)
        {
            if (customerAge <= 12 || customerAge >= 65)
            {
                return RegularPrice-DiscountedPrice;
            }
            return RegularPrice;
        }
    }

    // Class to handle user interaction and input
    class TicketCalculation
    {
        static void Main(string[] args)
        {
            AgeBasedPricing pricing = new AgeBasedPricing();
            Console.WriteLine("Welcome to the Movie Ticket Price Calculator\n");

            try
            {
                // Input: Get the customer's age
                Console.Write("Please enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                // Calculate and display the ticket price
                double price = pricing.CalculatePrice(age);
                Console.WriteLine($"The ticket price for someone aged {age} is GHC{price}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid numerical age.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
