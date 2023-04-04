//Chapter 001, Task 009
//23.03.2023, 23:56
using System;

public class PrintSerie
{
    static void Main()
    {
        for(int i = 2; i <= 102; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine($"-{i}");
            }
        }
    }
}