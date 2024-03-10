using System;

class BinaryTriangle
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the binary triangle: ");
        int numRows = int.Parse(Console.ReadLine());

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write((j % 2 == 0) ? "0" : "1");
            }
            Console.WriteLine();
        }
    }
}
