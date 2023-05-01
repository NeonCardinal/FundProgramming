//String and text processing, Example 007
//01.05.2023, 20:12
using System;
using System.Text;

public class ElegantNumbersConcatenator
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now);

        StringBuilder sb = new StringBuilder();

        sb.Append("Numbers: ");

        for(int i = 1; i <= 200000; i++)
        {
            sb.Append(i);
        }

        Console.WriteLine(sb.ToString().Substring(0, 1024));
        Console.WriteLine(DateTime.Now);
    }
}