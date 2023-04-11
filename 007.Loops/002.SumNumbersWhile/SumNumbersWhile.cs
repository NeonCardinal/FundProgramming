//Loops, Task 002
//07.04.2023, 22:21
using System;

public class SumNumbersWhile
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int num = 1;
        int sum = 1;

        Console.Write("The sum 1");

        while (num < n)
        {
            num++;
            sum += num;

            Console.Write(" + " + num);
        }

        Console.WriteLine(" = " + sum);
    }
}