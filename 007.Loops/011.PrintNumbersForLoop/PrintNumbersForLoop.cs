//Loops, Task 011
//08.04.2023, 22:26
using System;

public class PrintNumbersForLoop
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}