//Objects and classes, Task 010
//30.04.2023, 15:00
using System;
using System.Linq;

public class CalculateSum
{
    static void Main()
    {
        string str = "43 68 9 23 318";
        int[] arr = str.Split().Select(int.Parse).ToArray();

        int sum = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine(sum);
    }
}