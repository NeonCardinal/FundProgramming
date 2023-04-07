//Console input and output, Task 007
//04.04.2023, 12:57
using System;

public class GreaterNumber
{
    static void Main()
    {
        int sum = 0;
        int number;

        for(int i = 0; i < 5; i++)
        {
            if(!(int.TryParse(Console.ReadLine(), out number)))
            {
                i--;
            }

            sum += number;
        }

        Console.WriteLine(sum);
    }
}