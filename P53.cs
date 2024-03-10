using System;
using System.Collections.Generic;

class UniqueElements
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

        HashSet<int> uniqueElements = new HashSet<int>(array);

        Console.WriteLine("\nUnique elements in the array:");

        foreach (int element in uniqueElements)
        {
            Console.Write($"{element} ");
        }
    }
}
