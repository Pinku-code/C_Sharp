using System;

class Program
{
    static bool IsPalindrome(string str)
    {
        int length = str.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
            Console.WriteLine(input + " is a palindrome.");
        else
            Console.WriteLine(input + " is not a palindrome.");
    }
}
