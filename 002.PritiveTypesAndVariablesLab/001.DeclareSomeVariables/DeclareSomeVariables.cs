//Chapter 002, Task 001
//01.04.2023, 21:15
using System;

public class DeclareSomeVariables
{
    static void Main()
    {
        byte centuries = 20;
        ushort years = 2000;
        uint days = 730480;
        ulong hours = 17531520;

        Console.WriteLine(centuries + " centuries are " + years + " years, or " +
            days + " days, or " + hours + " hours.");

        ulong maxValue = ulong.MaxValue;

        Console.WriteLine(maxValue);
    }
}