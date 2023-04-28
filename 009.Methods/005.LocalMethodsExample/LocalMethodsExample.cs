//Methods, Example 005
//28.04.2023, 21:14
using System;

public class LocalMethodsExample
{
    static void Main()
    {
        int age = 17;

        void PrintAgeAfter(int years) => Console.WriteLine(age + years);

        PrintAgeAfter(3);
    }
}