//Methods, Task 004
//28.04.2023, 22:57
using System;

public class CountTImes
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"{number} se sreshta {Counter(arr, number)} v masiva.");
    }

    static int Counter(int[] numbers, int number)
    {
        int cnt = 0;

        for(int i = 0; i < numbers.Length; i++)
        {
            if(number == numbers[i])
            {
                cnt++;
            }
        }

        return cnt;
    }
}