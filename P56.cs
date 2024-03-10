using System;
using System.Collections.Generic;

class SeparateOddEven
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        List<int> oddNumbers = new List<int>();
        List<int> evenNumbers = new List<int>();

        foreach (int element in array)
        {
            if (element % 2 == 0)
                evenNumbers.Add(element);
            else
                oddNumbers.Add(element);
        }

        Console.WriteLine("\nOdd numbers in the array:");

        foreach (int oddNumber in oddNumbers)
        {
            Console.Write($"{oddNumber} ");
        }

        Console.WriteLine("\nEven numbers in the array:");

        foreach (int evenNumber in evenNumbers)
        {
            Console.Write($"{evenNumber} ");
        }
    }
}
