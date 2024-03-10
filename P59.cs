using System;

class InsertValueUnsortedArray
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] unsortedArray = new int[n + 1];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            unsortedArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the value to insert: ");
        int valueToInsert = int.Parse(Console.ReadLine());

        // Insert the new value at the end of the array
        unsortedArray[n] = valueToInsert;

        Console.WriteLine("\nArray after inserting the value:");

        foreach (int element in unsortedArray)
        {
            Console.Write($"{element} ");
        }
    }
}
