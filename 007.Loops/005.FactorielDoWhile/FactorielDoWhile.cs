//Loops, Task 005
//07.04.2023, 22:36
using System;

public class FactorielDoWhile
{
    static void Main()
    {
        Console.Write("n = ");

        int n = int.Parse(Console.ReadLine());

        decimal factoriel = 1;

        do
        {
            factoriel *= n;
            n--;
        }
        while (n >= 1);

        Console.WriteLine($"n! = {factoriel}");
    }
}