using System;
using System.Collections.Generic;

class CountDuplicates
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

        Dictionary<int, int> elementCount = new Dictionary<int, int>();

        foreach (int element in array)
        {
            if (elementCount.ContainsKey(element))
                elementCount[element]++;
            else
                elementCount[element] = 1;
        }

        Console.WriteLine("\nDuplicate elements and their counts:");

        foreach (var pair in elementCount)
        {
            if (pair.Value > 1)
                Console.WriteLine($"{pair.Key}: {pair.Value} times");
        }
    }
}
