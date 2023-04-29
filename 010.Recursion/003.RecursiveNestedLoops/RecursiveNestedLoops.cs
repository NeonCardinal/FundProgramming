//Recursion, Example 003
//28.04.2023, 23:41
using System;

public class RecursiveNestedLoops
{
    static int numberOfLoops;
    static int numberOfIterations;
    static int[] loops;

    static void Main()
    {
        Console.Write("N = ");
        numberOfLoops = int.Parse(Console.ReadLine());

        Console.Write("K = ");
        numberOfIterations = int.Parse(Console.ReadLine());

        loops = new int[numberOfLoops];

        NestedLoops(0);
    }

    static void NestedLoops(int currentLoop)
    {
        if(currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }

        for(int i = 1; i <= numberOfIterations; i++)
        {
            loops[currentLoop] = i;
            NestedLoops(currentLoop + 1);
        }
    }

    static void PrintLoops()
    {
        for(int i = 0; i < numberOfLoops; i++)
        {
            Console.Write($"{loops[i]} ");
        }

        Console.WriteLine();
    }
}