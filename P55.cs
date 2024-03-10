using System;

class MinMaxArrayElements
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

        int maxElement = int.MinValue;
        int minElement = int.MaxValue;

        foreach (int element in array)
        {
            if (element > maxElement)
                maxElement = element;

            if (element < minElement)
                minElement = element;
        }

        Console.WriteLine($"Maximum element: {maxElement}");
        Console.WriteLine($"Minimum element: {minElement}");
    }
}
