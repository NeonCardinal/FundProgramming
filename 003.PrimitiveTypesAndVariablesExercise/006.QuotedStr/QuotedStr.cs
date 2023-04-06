//Primitive types and variables - exercise, Task 009
//03.04.2023, 17:51
using System;

public class QuotedStr
{
    static void Main()
    {
        string str1 = "The \"use\" of quotations causes difficulties.";
        string str2 = @"The ""use"" of quatations causes difficulties.";

        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}