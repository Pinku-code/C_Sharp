using System;

class PascalTriangle
{
    // Function to calculate binomial coefficient
    static int BinomialCoefficient(int n, int k)
    {
        if (k == 0 || k == n)
            return 1;
        return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
    }

    static void Main()
    {
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int numRows = int.Parse(Console.ReadLine());

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{BinomialCoefficient(i, j)} ");
            }
            Console.WriteLine();
        }
    }
}
