//Operators and expressions, Task 001
//03.04.2023, 18:49
using System;

public class OddOrEven
{
    static void Main()
    {
        int number = 19;

        bool isOdd = number % 2 == 1;

        Console.WriteLine(isOdd ? "odd" : "even");
    }
}