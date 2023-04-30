//Objects and classes, Task 004
//30.04.2023, 14:54
using System;

public class TimeFromStart
{
    static void Main()
    {
        long time = Environment.TickCount;

        long seconds = time / 1000;
        int minutes = (int)seconds / 60;
        int hours = minutes / 60;
        int days = hours / 24;

        Console.WriteLine($"Time from start: {days} days, {hours} hours, {minutes} minutes");
    }
}