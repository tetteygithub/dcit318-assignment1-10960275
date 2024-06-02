using System;

namespace TriangleClassifierApp
{
    // Class to classify a triangle based on its sides
    class TriangleClassifier
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public string Classify()
        {
            if (SideA == SideB && SideB == SideC)
            {
                return "Equilateral";
            }
            else if (SideA == SideB || SideB == SideC || SideA == SideC)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }

    // Class to handle user input and interaction with the TriangleClassifier
    class TriangleIdentifier
    {
        static void Main(string[] args)
        {
            TriangleClassifier classifier = new TriangleClassifier();
            Console.WriteLine("Triangle Type Identifier\n");

            try
            {
                // Input: Get the lengths of the three sides
                Console.Write("Enter the length of the first side: ");
                classifier.SideA = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the length of the second side: ");
                classifier.SideB = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the length of the third side: ");
                classifier.SideC = Convert.ToDouble(Console.ReadLine());

                // Determine and display the type of the triangle
                string triangleType = classifier.Classify();
                Console.WriteLine($"The triangle with sides {classifier.SideA}, {classifier.SideB}, and {classifier.SideC} is {triangleType}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter valid numerical values.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
