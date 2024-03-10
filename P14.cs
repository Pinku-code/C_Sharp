using System;

class Program
{
    static void Main()
    {
        int n = 10;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number " + i + ": ");
            int num = Convert.ToInt32(Console.ReadLine());
            sum += num;
        }

        double average = (double)sum / n;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
    }
}
