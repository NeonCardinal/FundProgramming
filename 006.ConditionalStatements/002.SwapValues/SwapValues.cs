//Conditional statements, Task 001
//04.04.2023, 14:37
using System;

public class SwapValues
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if(a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}