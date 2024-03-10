using System;

class MergeArrays
{
    static void Main()
    {
        Console.Write("Enter the number of elements in each array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array1 = new int[n];
        int[] array2 = new int[n];

        Console.WriteLine("Enter the elements of the first sorted array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nEnter the elements of the second sorted array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        int[] mergedArray = new int[2 * n];
        int index1 = 0, index2 = 0, indexMerged = 0;

        while (index1 < n && index2 < n)
        {
            if (array1[index1] < array2[index2])
            {
                mergedArray[indexMerged] = array1[index1];
                index1++;
            }
            else
            {
                mergedArray[indexMerged] = array2[index2];
                index2++;
            }

            indexMerged++;
        }

        while (index1 < n)
        {
            mergedArray[indexMerged] = array1[index1];
            index1++;
            indexMerged++;
        }

        while (index2 < n)
        {
            mergedArray[indexMerged] = array2[index2];
            index2++;
            indexMerged++;
        }

        Console.WriteLine("\nMerged array in ascending order:");

        foreach (int element in mergedArray)
        {
            Console.Write($"{element} ");
        }
    }
}
