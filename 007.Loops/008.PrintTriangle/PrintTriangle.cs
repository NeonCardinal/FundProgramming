//Loops, Task 008
//08.04.2023, 21:15
using System;

public class PrintTriangle
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }

            Console.WriteLine();
        }
    }
}