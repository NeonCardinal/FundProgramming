//Console input and output, Task 010
//04.04.2023, 13:07
using System;

public class FibonaciSerie
{
    static void Main()
    {
        long first = 0;
        long second = 1;

        Console.WriteLine(first);
        Console.WriteLine(second);

        for(int i = 1; i <= 100; i++)
        {
            long fib = first + second;
            first = second;
            second = fib;

            Console.WriteLine(fib);
        }
    }
}