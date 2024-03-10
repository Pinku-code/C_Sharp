using System;

class ArmstrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int result = 0;
        int n = number.ToString().Length;

        while (number > 0)
        {
            int digit = number % 10;
            result += (int)Math.Pow(digit, n);
            number /= 10;
        }

        if (result == originalNumber)
            Console.WriteLine($"{originalNumber} is an Armstrong number.");
        else
            Console.WriteLine($"{originalNumber} is not an Armstrong number.");
    }
}
