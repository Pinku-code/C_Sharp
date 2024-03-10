using System;

class CopyArray
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] originalArray = new int[n];
        int[] copiedArray = new int[n];

        Console.WriteLine("Enter the elements of the original array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            originalArray[i] = int.Parse(Console.ReadLine());
        }

        // Copy elements from originalArray to copiedArray
        Array.Copy(originalArray, copiedArray, n);

        Console.WriteLine("\nElements in the copied array:");

        foreach (int element in copiedArray)
        {
            Console.Write($"{element} ");
        }
    }
}
