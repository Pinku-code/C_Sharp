using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        if (num1 == num2)
        {
            Console.WriteLine("Triple of the sum: " + (sum * 3));
        }
        else
        {
            Console.WriteLine("Sum: " + sum);
        }
    }
}
