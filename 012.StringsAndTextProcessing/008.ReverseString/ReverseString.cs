//Strings and text processing, Example 008
//01.05.2023, 20:15
using System;
using System.Text;

public class ReverseString
{
    static void Main()
    {
        string text = "Neshto";

        string reversed = ReverseText(text);

        Console.WriteLine(reversed);
    }

    static string ReverseText(string str)
    {
        StringBuilder sb = new StringBuilder();

        for(int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }

        return sb.ToString();
    }
}