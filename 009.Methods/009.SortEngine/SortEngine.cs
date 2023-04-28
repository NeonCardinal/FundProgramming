//Methods, Example 009
//28.04.2023, 21:52
using System;

public class SortEngine
{
    static void Main()
    {
        int[] numbers = Sort( 10, 3, 5, -1, 0, 12, 8);

        PrintNumbers(numbers);
    }

    static int[] Sort(params int[] numbers)
    {
        for(int i = 0; i < numbers.Length - 1; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                if(numbers[i] > numbers[j])
                {
                    int oldNum = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = oldNum;
                }
            }
        }

        return numbers;
    }

    static void PrintNumbers(params int[] numbers)
    {
        Console.WriteLine($"[{String.Join(", ", numbers)}]");
    }
}