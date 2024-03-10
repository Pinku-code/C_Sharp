using System;

class InsertValueSortedArray
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] sortedArray = new int[n + 1];

        Console.WriteLine("Enter the sorted elements of the array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            sortedArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the value to insert: ");
        int valueToInsert = int.Parse(Console.ReadLine());

        int indexToInsert = 0;

        for (int i = 0; i < n; i++)
        {
            if (valueToInsert < sortedArray[i])
            {
                indexToInsert = i;
                break;
            }
        }

        // Shift elements to the right to make space for the new value
        for (int i = n; i > indexToInsert; i--)
        {
            sortedArray[i] = sortedArray[i - 1];
        }

        // Insert the new value at the correct position
        sortedArray[indexToInsert] = valueToInsert;

        Console.WriteLine("\nArray after inserting the value:");

        foreach (int element in sortedArray)
        {
            Console.Write($"{element} ");
        }
    }
}
