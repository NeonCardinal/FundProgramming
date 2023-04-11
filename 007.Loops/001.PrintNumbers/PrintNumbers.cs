//Loops, Task 001
//07.04.2023, 22:20
using System;

public class PrintNumbers
{
    static void Main()
    {
        int counter = 5;

        while(counter <= 10)
        {
            Console.WriteLine($"Number: {counter}");

            counter++;
        }
    }
}