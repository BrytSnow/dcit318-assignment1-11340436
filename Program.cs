using System;

class TicketCalculator
{
    static void Main(string[] args)
    {
        int age;

        while (true)
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age > 0)
                {
                    int price = (age <= 12 || age >= 65) ? 7 : 10;
                    Console.WriteLine($"Your ticket price is: GHC{price}");
                    break;
                }
                else
                {
                    Console.WriteLine("Age must be greater than zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
