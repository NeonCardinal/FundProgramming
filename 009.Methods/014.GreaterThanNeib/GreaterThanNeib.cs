//Methods, Task 005
//28.04.2023, 23:04
using System;

public class GreaterThanNeib
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        Console.Write("Vuvedete chislo za index (0 - 14): ");
        int index = int.Parse(Console.ReadLine());

        bool greater = IsGreater(arr, index);

        if(greater)
        {
            Console.WriteLine("Yes, the number is greater.");
        }
        else
        {
            Console.WriteLine("No, the number is not greater.");
        }
    }

    static bool IsGreater(int[] numbers, int index)
    {
        bool result = (numbers[index] > numbers[index - 1]) && (numbers[index] > numbers[index + 1]);

        return result;
    }
}