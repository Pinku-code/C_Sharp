using System;

class SumOfTwoPrimes
{
    // Function to check if a number is prime
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        bool expressibleAsSum = false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (IsPrime(i) && IsPrime(n - i))
            {
                expressibleAsSum = true;
                break;
            }
        }

        if (expressibleAsSum)
            Console.WriteLine($"{n} can be expressed as the sum of two prime numbers.");
        else
            Console.WriteLine($"{n} cannot be expressed as the sum of two prime numbers.");
    }
}
