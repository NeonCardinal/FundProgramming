//Methods, Example 004
//28.04.2023, 20:02
using System;

public class Triangle
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for(int i = 1; i <= n; i++)
        {
            PrintLine(1, i);
        }

        for(int i = n - 1; i >= 1; i--)
        {
            PrintLine(1, i);
        }
    }

    static void PrintLine(int start, int end)
    {
        for(int i = start; i <= end; i++)
        {
            Console.Write(" " + i);
        }

        Console.WriteLine();
    }
}