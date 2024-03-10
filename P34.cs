using System;

class ArmstrongNumbersInRange
{
    static void Main()
    {
        Console.WriteLine("Armstrong numbers between 1 and 1000:");

        for (int i = 1; i <= 1000; i++)
        {
            int number = i;
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
                Console.WriteLine(originalNumber);
        }
    }
}
