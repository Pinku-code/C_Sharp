using System;

class Marksheet
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter marks in Physics: ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Enter marks in Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());

        Console.Write("Enter marks in Mathematics: ");
        int mathematics = int.Parse(Console.ReadLine());

        int totalMarks = physics + chemistry + mathematics;
        double percentage = (double)totalMarks / 3;

        Console.WriteLine("\nMark Sheet");
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Physics: {physics}");
        Console.WriteLine($"Chemistry: {chemistry}");
        Console.WriteLine($"Mathematics: {mathematics}");
        Console.WriteLine($"Total Marks: {totalMarks}");
        Console.WriteLine($"Percentage: {percentage:F2}%");
    }
}
