//Loops, Task 013
//08.04.2023, 22:31
using System;

public class MinAndMax
{
    static void Main()
    {
        int min = int.MaxValue;
        int max = int.MinValue;

        for(int i = 0; i < 10; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number < min)
            {
                min = number;
            }

            if(number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"max = {max}");
        Console.WriteLine($"min = {min}");
    }
}