//Strings and text processing, Example 002
//01.05.2023, 00:40
using System;

public class CompareExample
{
    static void Main()
    {
        string score = "sCore";
        string scary = "scary";

        Console.WriteLine(score.CompareTo(scary));
        Console.WriteLine(scary.CompareTo(score));
        Console.WriteLine(scary.CompareTo(scary));
    }
}