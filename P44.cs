using System;

class DateCalculator
{
    static void Main()
    {
        Console.Write("Enter the first date (YYYY-MM-DD): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the second date (YYYY-MM-DD): ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        TimeSpan duration = endDate - startDate;
        int days = duration.Days;

        Console.WriteLine($"Number of days between the two dates: {days}");
    }
}
