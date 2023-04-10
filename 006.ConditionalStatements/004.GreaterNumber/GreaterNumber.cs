//Conditional statements, Task 003
//04.04.2023, 14:42
using System;

public class GreaterNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int greater = 0;

        if (a > b)
        {
            greater = a;
        }
        else
        {
            greater = b;
        }

        if (a > c)
        {
            greater = a;
        }
        else
        {
            greater = c;
        }

        if (b > c)
        {
            greater = b;
        }
        else
        {
            greater = c;
        }

        if (b > a)
        {
            greater = b;
        }
        else
        {
            greater = a;
        }

        if (c > b)
        {
            greater = c;
        }
        else
        {
            greater = b;
        }

        Console.WriteLine($"Greater number is: {greater}");
    }
}