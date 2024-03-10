using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string hexadecimal = Convert.ToString(decimalNumber, 16).ToUpper();
        Console.WriteLine($"Hexadecimal equivalent: {hexadecimal}");
    }
}
