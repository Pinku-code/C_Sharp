using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        char firstLetter = name.ToUpper()[0];

        for (char i = 'A'; i <= firstLetter; i++)
        {
            for (char j = 'A'; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
