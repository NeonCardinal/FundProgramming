//Arrays, Task 004
//24.04.2023, 21:51
using System;

public class MaxPlatform
{
    static void Main()
    {
        int[,] matrix =
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for(int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for(int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                if(sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = i;
                    bestCol = j;
                }
            }
        }

        Console.WriteLine("The best platform is:");
        Console.Write($" {matrix[bestRow, bestCol]}");
        Console.WriteLine($" {matrix[bestRow, bestCol + 1]}");
        Console.Write($" {matrix[bestRow + 1, bestCol]}");
        Console.WriteLine($" {matrix[bestRow + 1, bestCol + 1]}");
        Console.WriteLine($"The maximal sum is: {bestSum}");
    }
}