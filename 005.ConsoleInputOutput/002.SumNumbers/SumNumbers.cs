//Console input and output, Task 001
//04.04.2023, 12:37
using System;

public class SumNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int sum = a + b + c;

        Console.WriteLine(sum);
    }
}