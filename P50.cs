using System;

class SumOfArrayElements
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

        int sum = 0;

        foreach (int element in array)
        {
            sum += element;
        }

        Console.WriteLine($"Sum of array elements: {sum}");
    }
}
