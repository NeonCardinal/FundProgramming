//Operators and expressions, Task 002
//03.04.2023, 18:51
using System;

public class DivideByFiveAndSeven
{
    static void Main()
    {
        int number = 31;

        bool isDivide = number % 5 == 0 && number % 7 == 0;

        Console.WriteLine(isDivide ? "yes" : "no");
    }
}