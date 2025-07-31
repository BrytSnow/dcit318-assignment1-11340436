using System;

class TriangleIdentifier
{
    static void Main(string[] args)
    {
        double side1, side2, side3;


        Console.Write("Enter the length of side1: ");
        while (!double.TryParse(Console.ReadLine(), out side1) || side1 <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number for side1: ");
        }


        Console.Write("Enter the length of side2: ");
        while (!double.TryParse(Console.ReadLine(), out side2) || side2 <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number for side2: ");
        }


        Console.Write("Enter the length of side3: ");
        while (!double.TryParse(Console.ReadLine(), out side3) || side3 <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number for side3: ");
        }


        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }
}
