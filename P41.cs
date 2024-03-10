using System;

class RemoveDuplicates
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string result = new string(input.Distinct().ToArray());
        Console.WriteLine($"String with duplicates removed: {result}");
    }
}
