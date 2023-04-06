//Primitive types and variables - exercise, Task 013
//03.04.2023, 18:05
using System;

public class SwapValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}