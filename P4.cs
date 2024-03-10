using System;

class Program
{
    static void Main()
    {
        int num1 = 5;
        int num2 = 10;

        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;

        Console.WriteLine("Swapped values: " + num1 + ", " + num2);
    }
}
