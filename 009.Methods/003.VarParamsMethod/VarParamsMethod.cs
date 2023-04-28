//Methods, Example 003
//28.04.2023, 19:39
using System;

public class VarParamsMethod
{
    static void Main()
    {
        long sum = CalcSum(2, 5);
        Console.WriteLine(sum);

        long sum2 = CalcSum(4, 0, -2, 12);
        Console.WriteLine(sum2);

        long sum3 = CalcSum();
        Console.WriteLine(sum3);
    }

    static long CalcSum(params int[] elements)
    {
        long sum = 0;

        foreach(int element in elements)
        {
            sum += element;
        }

        return sum;
    }
}