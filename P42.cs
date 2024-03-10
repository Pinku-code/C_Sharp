using System;

class Factors
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"Factors of {n}: ");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.Write($"{i} ");
        }
    }
}
