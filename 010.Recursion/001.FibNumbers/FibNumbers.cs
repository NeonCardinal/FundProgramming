//Recursion, Example 001
//28.04.2023, 23:26
using System;

public class FibNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Fib(n));
    }

    static long Fib(int n)
    {
        if(n <= 2)
        {
            return 1;
        }

        return Fib(n - 1) + Fib(n - 2);
    }
}