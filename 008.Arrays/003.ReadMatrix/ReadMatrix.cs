//Arrays, Task 003
//24.04.2023, 24:42
using System;

public class ReadMatrix
{
    static void Main()
    {
        Console.Write("Enter the number of the rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of the cols: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for(int row = 0; row < rows; row++)
        {
            for(int col = 0; col < cols; col++)
            {
                Console.Write($"matrix[{row},{col}] = ");
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($" {matrix[i, j]}");
            }

            Console.WriteLine();
        }
    }
}