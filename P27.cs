using System;

class Program
{
    static int SumOfDigits(int num)
    {
        if (num == 0)
            return 0;

        return num % 10 + SumOfDigits(num / 10);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = SumOfDigits(num);

        Console.WriteLine("Sum of digits: " + sum);
    }
}
