//Loops, Task 010
//08.04.2023, 22:16
using System;

public class HappyNumbers
{
    static void Main()
    {
        for(int a = 1; a <= 9; a++)
        {
            for(int b = 0; b <= 9; b++)
            {
                for(int c = 0; c <= 9; c++)
                {
                    for(int d = 0; c <= 9; d++)
                    {
                        if((a + b) == (c + d))
                        {
                            Console.WriteLine($" {a} {b} {c} {d} ");
                        }
                    }
                }
            }
        }
    }
}