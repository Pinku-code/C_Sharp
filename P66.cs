using System;

class DiamondPattern
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the diamond pattern: ");
        int numRows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numRows; i++)
        {
            for (int j = 1; j <= numRows - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = numRows - 1; i >= 1; i--)
        {
            for (int j = 1; j <= numRows - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
