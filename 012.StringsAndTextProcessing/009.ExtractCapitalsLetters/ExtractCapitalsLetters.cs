//Strings and text processing, Example 009
//02.05.2023, 17:16
using System;
using System.Text;

public class ExtractCapitalsLetters
{
    static void Main()
    {
        string str = "Hello NikI";

        string result = ExtractCapitals(str);

        Console.WriteLine(result);
    }

    static string ExtractCapitals(string str)
    {
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            if(char.IsUpper(ch))
            {
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }
}