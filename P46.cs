using System;

class DecimalToOctal
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string octal = Convert.ToString(decimalNumber, 8);
        Console.WriteLine($"Octal equivalent: {octal}");
    }
}
