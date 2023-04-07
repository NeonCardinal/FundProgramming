//Operators and expressions, Task 004
//03.04.2023, 19:00
using System;

public class ChekBit
{
    static void Main()
    {
        int number = 21;

        bool bitThree = (number & 8) != 0;

        Console.WriteLine(bitThree);
    }
}