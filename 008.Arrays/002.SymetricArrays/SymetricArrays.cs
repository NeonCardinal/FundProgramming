//Arrays, Task 002
//11.04.2023, 23:31
using System;

public class SymetricArrays
{
    static void Main()
    {
        Console.Write("Enter positive integer: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for(int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        bool symetric = true;

        for(int i = 0; i < array.Length / 2; i++)
        {
            if(array[i] != array[n - i - 1])
            {
                symetric = false;
                break;
            }
        }

        Console.WriteLine($"Is symetric? {symetric}");
    }
}