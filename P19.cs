using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = 1;
            for (int j = 0; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
}
