using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        int decimalNumber = Convert.ToInt32(binaryNumber, 2);
        Console.WriteLine($"Decimal equivalent: {decimalNumber}");
    }
}
