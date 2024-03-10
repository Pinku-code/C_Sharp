using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(decimalNumber, 2);
        Console.WriteLine($"Binary equivalent: {binary}");
    }
}
