using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int term = 0;

        for (int i = 1; i <= n; i++)
        {
            term = term * 10 + 1;
            sum += term;
        }

        Console.WriteLine("Sum of the series: " + sum);
    }
}
