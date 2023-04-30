//Objects and classes, Example 002
//30.04.2023, 13:27
using System;

public class SystemTest
{
    static void Main()
    {
        int sum = 0;
        int startTime = Environment.TickCount;

        for(int i = 0; i < 10000000; i++)
        {
            sum++;
        }

        int endTime = Environment.TickCount;

        Console.WriteLine($"The time elapsed is {(endTime - startTime) / 1000.0}");
    }
}