//Recursion, Example 002
//28.04.2023, 23:33
using System;

public class RecursiveFactorial
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        decimal factorial = Factorial(n);

        Console.WriteLine($"{n}! = {factorial}");
    }

    static decimal Factorial(int n)
    {
        if(n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}