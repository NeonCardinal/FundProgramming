//Chapter 002, Task 006
//02.04.2023, 22:33
using System;

public class CharExample
{
    static void Main()
    {
        char symbol = 'a';

        Console.WriteLine($"The code of '{symbol}' is {(int)symbol}");

        symbol = 'b';

        Console.WriteLine($"The code of '{symbol}' is {(int)symbol}");

        symbol = 'A';

        Console.WriteLine($"The code of '{symbol}' is {(int)symbol}");
    }
}