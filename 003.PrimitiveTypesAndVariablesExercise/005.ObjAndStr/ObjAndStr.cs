//Primitive types and variables - exercise, Task 008
//03.04.2023, 17:49
using System;

public class ObjAndStr
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        object obj = str1 + " " + str2;
        string str = (string)obj;

        Console.WriteLine(str);
    }
}