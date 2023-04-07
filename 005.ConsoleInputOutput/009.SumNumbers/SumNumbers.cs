//Console input and output, Task 009
//04.04.2023, 13:05
using System;

public class SumNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            sum += number;
        }

        Console.WriteLine(sum);
    }
}