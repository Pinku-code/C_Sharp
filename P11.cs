using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 != 0)
            {
                double result = num1 / num2;
                Console.WriteLine("Result of division: " + result);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
    }
}
