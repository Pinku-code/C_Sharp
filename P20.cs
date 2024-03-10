using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(num);

        Console.WriteLine("Factorial of " + num + ": " + result);
    }
}
