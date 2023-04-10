//Conditional statements, Task 007
//07.04.2023, 21:32
using System;

public class SortNumbers
{
    static void Main()
    {
        int greater = int.MinValue;

        for(int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number > greater)
            {
                greater = number;
            }
        }

        Console.WriteLine(greater);
    }
}