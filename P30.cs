using System;

class Program
{
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
        Console.Write("Enter the upper limit for prime numbers: ");
        int upperLimit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prime numbers up to " + upperLimit + ":");

        for (int i = 2; i <= upperLimit; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}
