using System;

class BitwiseOperators
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Bitwise AND: {a & b}");
        Console.WriteLine($"Bitwise OR: {a | b}");
        Console.WriteLine($"Bitwise XOR: {a ^ b}");
        Console.WriteLine($"Bitwise NOT (complement) of {a}: {~a}");
        Console.WriteLine($"Bitwise left shift of {a} by 1: {a << 1}");
        Console.WriteLine($"Bitwise right shift of {a} by 1: {a >> 1}");
    }
}
