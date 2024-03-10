using System;

class Program
{
    static int Factorial(int num)
    {
        if (num == 0 || num == 1)
            return 1;
        else
            return num * Factorial(num - 1);
    }

    static bool IsStrongNumber(int num)
    {
        int originalNum = num;
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += Factorial(digit);
            num /= 10;
        }

        return sum == originalNum;
    }

    static void Main()
    {
        Console.Write("Enter the lower limit of the range: ");
        int lowerLimit = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the upper limit of the range: ");
        int upperLimit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Strong numbers within the range:");

        for (int i = lowerLimit; i <= upperLimit; i++)
        {
            if (IsStrongNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}
