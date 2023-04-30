//Objects and classes, Task 001
//30.04.2023, 14:48
using System;

public class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine(DateTime.IsLeapYear(year));
    }
}