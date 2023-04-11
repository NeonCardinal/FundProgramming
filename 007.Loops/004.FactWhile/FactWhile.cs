//Loops, Task 004
//07.04.2023, 22:32
using System;

public class FactWhile
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal factoriel = 1;

        while(true)
        {
            if(n <= 1)
            {
                break;
            }

            factoriel *= n;
            n--;
        }

        Console.WriteLine($"n! = {factoriel}");
    }
}