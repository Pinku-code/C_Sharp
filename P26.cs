using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the lower limit of the range: ");
        int lowerLimit = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the upper limit of the range: ");
        int upperLimit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Even numbers in the range:");

        for (int i = lowerLimit; i <= upperLimit; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Odd numbers in the range:");

        for (int i = lowerLimit; i <= upperLimit; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
