using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int count = 0;
        int i = 2;

        while (count < n)
        {
            if (IsPrime(i))
            {
                sum += i;
                count++;
            }
            i++;
        }

        Console.WriteLine("Sum of the first " + n + " prime numbers: " + sum);
    }
}
