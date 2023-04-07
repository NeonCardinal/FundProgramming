//Console input and output, Task 008
//04.04.2023, 13:02
using System;

public class GreaterNumber
{
    static void Main()
    {
        int greater = int.MinValue;

        for(int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine());

            greater = Math.Max(greater, number);
        }

        Console.WriteLine(greater);
    }
}