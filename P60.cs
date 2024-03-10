using System;

class DeleteElementFromArray
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

        Console.Write("Enter the position of the element to delete: ");
        int positionToDelete = int.Parse(Console.ReadLine());

        if (positionToDelete < 1 || positionToDelete > n)
        {
            Console.WriteLine("Invalid position. Deletion failed.");
        }
        else
        {
            // Shift elements to the left to remove the element at the specified position
            for (int i = positionToDelete - 1; i < n - 1; i++)
            {
                array[i] = array[i + 1];
            }

            // Decrease the size of the array
            Array.Resize(ref array, n - 1);

            Console.WriteLine("\nArray after deleting the element:");

            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
