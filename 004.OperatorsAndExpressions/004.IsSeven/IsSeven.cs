//Operatiors and expressions, Task 003
//03.04.2023, 18:54
using System;

public class IsSeven
{
    static void Main()
    {
        int number = 137;

        int digit = number % 10;

        Console.WriteLine(digit == 7 ? "yes" : "no");
    }
}