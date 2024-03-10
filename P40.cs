using System;

class ReverseEachWord
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = new string(charArray);
        }

        string reversedString = string.Join(" ", words);
        Console.WriteLine($"String with reversed words: {reversedString}");
    }
}
