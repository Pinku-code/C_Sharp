using System;

class Program
{
    static int FindHCF(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int hcf = FindHCF(num1, num2);

        Console.WriteLine("HCF of " + num1 + " and " + num2 + ": " + hcf);
    }
}
