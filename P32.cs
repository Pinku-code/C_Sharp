using System;

class Program
{
    static int ReverseNumber(int num)
    {
        int reversed = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        return reversed;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int reversed = ReverseNumber(num);

        Console.WriteLine("Reversed number: " + reversed);
    }
}
