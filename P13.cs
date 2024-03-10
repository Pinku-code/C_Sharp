using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = (n * (n + 1)) / 2;

        Console.WriteLine("Sum of first " + n + " natural numbers: " + sum);
    }
}
