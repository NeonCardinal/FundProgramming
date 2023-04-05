//Chapter 002, Task 005;
//02.04.2023, 21:35
using System;

public class BoolExample
{
    static void Main()
    {
        int a = 1;
        int b = 2;

        bool greaterAB = (a > b);
        bool equalA1 = a == 1;

        if(greaterAB)
        {
            Console.WriteLine("A > B");
        }
        else
        {
            Console.WriteLine("B > A");
        }

        Console.WriteLine($"greaterAB = {greaterAB}");
        Console.WriteLine($"equalA1 = {equalA1}");
    }
}