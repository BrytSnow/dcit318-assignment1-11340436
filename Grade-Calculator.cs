using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        double grade;

        while (true)
        {
            Console.Write("Enter your numerical grade (0 - 100): ");
            if (double.TryParse(Console.ReadLine(), out grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    string letterGrade = grade switch
                    {
                        >= 90 => "A",
                        >= 80 => "B",
                        >= 70 => "C",
                        >= 60 => "D",
                        _ => "F"
                    };
                    Console.WriteLine($"Your letter grade is: {letterGrade}");
                    break;
                }
                else
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value! ");
            }
        }
    }
}
