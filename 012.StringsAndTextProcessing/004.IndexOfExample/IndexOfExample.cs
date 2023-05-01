//Strings and text processing, Example 004
//01.05.2023, 19:37
using System;

public class IndexOfExample
{
    static void Main()
    {
        string quote = "The main intent of the \"Intro C#\"" +
            " book is to introduce the C# programming to newbies.";
        string keyword = "C#";
        int index = quote.IndexOf(keyword);

        while(index != -1)
        {
            Console.WriteLine($"{keyword} found at index: {index}");
            index = quote.IndexOf(keyword, index + keyword.Length);
        }
    }
}