//Arrays, Task 006
//25.04.2023, 21:05
using System;

public class InitArray
{
    static void Main()
    {
        int[] arr = new int[20];

        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 5;
        }

        Console.WriteLine(String.Join(" ", arr));
    }
}