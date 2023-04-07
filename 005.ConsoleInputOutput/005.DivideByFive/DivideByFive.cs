//Console input and output, Task 005
//04.04.2023, 12:52
using System;

public class DivideByFive
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int cnt = 0;

        for(int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
                cnt++;
        }

        Console.WriteLine(cnt);
    }
}