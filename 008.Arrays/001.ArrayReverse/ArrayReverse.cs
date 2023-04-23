//Arrays, Task 001
//11.04.2023, 23:24
using System;

public class ArrayReverse
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        int length = array.Length;

        int[] reversed = new int[length];

        for (int i = 0; i < length; i++)
        {
            reversed[i] = array[length - i - 1];
        }

        for (int i = 0; i < length; i++)
        {
            Console.Write($"{reversed[i]} ");
        }
    }
}