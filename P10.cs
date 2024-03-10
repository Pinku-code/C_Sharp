using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third integer: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        if (num1 == num2)
            count++;

        if (num2 == num3)
            count++;

        if (num1 == num3)
            count++;

        Console.WriteLine(count + " integers have the same value.");
    }
}
