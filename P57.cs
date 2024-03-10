using System;

class SortArray
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

        Array.Sort(array);

        Console.WriteLine("\nSorted array in ascending order:");

        foreach (int element in array)
        {
            Console.Write($"{element} ");
        }
    }
}
