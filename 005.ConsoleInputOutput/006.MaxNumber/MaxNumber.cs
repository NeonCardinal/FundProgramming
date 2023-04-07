//Console input and output, Task 006
//04.04.2023, 12:54
using System;

public class MaxNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int greater = Math.Max(a, b);

        Console.WriteLine(greater);
    }
}