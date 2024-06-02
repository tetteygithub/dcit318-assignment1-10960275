using System;

namespace GradeEvaluatorApp
{
    // Class to evaluate the letter grade based on the numerical grade
    class GradeEvaluator
    {
        public double Grade { get; set; }

        public string Evaluate()
        {
            if (Grade >= 90)
            {
                return "A";
            }
            else if (Grade >= 80)
            {
                return "B";
            }
            else if (Grade >= 70)
            {
                return "C";
            }
            else if (Grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }

    // Class to handle user input and interaction with the GradeEvaluator
    class GradeCalc
    {
        static void Main(string[] args)
        {
            GradeEvaluator evaluator = new GradeEvaluator();
            Console.WriteLine("Grade Calculator\n");

            try
            {
                // Input: Get numerical grade
                Console.Write("Enter a numerical grade between 0 and 100: ");
                evaluator.Grade = Convert.ToDouble(Console.ReadLine());

                // Validate the input grade
                if (evaluator.Grade < 0 || evaluator.Grade > 100)
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                }
                else
                {
                    // Get the letter grade
                    string letterGrade = evaluator.Evaluate();
                    Console.WriteLine($"The letter grade for {evaluator.Grade} is {letterGrade}.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a numerical grade.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
