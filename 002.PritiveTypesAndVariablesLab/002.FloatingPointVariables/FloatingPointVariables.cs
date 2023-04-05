//Chapter 002, Task 002
//01.04.2023, 21:21
using System;

public class FloatingPointVariables
{
    static void Main()
    {
        float floatPI = 3.14F;
        Console.WriteLine(floatPI);

        double doublePI = 3.14;
        Console.WriteLine(doublePI);

        double num = 1.56e+12;
        Console.WriteLine(num);

        double nan = double.NaN;
        Console.WriteLine(nan);

        double infinity = double.PositiveInfinity;
        Console.WriteLine(infinity);
    }
}