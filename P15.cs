using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write($"{j} x {i} = {j * i}\t");
            }
            Console.WriteLine();
        }
    }
}
