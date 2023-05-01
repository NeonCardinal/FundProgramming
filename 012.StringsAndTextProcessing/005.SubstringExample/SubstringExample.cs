//Strings and text processing, Example 005
//01.05.2023, 19:46
using System;

public class SubstringExample
{
    static void Main()
    {
        string path = "C:\\Pics\\Rila2017.jpg";
        int index = path.LastIndexOf("\\");
        string fullName = path.Substring(index + 1);

        Console.WriteLine(fullName);
    }
}