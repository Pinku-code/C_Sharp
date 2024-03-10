using System;

class SecondSmallestElement
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

        if (n < 2)
        {
            Console.WriteLine("Array does not have a second smallest element.");
        }
        else
        {
            Array.Sort(array);
            Console.WriteLine($"Second smallest element: {array[1]}");
        }
    }
}
