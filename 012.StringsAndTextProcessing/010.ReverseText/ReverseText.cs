//Strings and text processing, Task 002
//02.05.2023, 17:21
using System;

public class ReverseText
{
    static void Main()
    {
        string text = Console.ReadLine();

        string reversed = "";

        for(int i = text.Length - 1; i >= 0; i--)
        {
            reversed += text[i];
        }

        Console.WriteLine(reversed);
    }
}