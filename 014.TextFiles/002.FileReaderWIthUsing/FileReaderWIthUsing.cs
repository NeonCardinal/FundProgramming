//Text Files, Example 002
//30.06.2023, 21:18
using System;
using System.IO;

public class FileReaderWIthUsing
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\..\\SampleText.txt");

        using(reader)
        {
            int lineNumber = 0;

            string line = reader.ReadLine();

            while(line != null)
            {
                lineNumber++;
                Console.WriteLine($"Line {lineNumber}: {line}");
                reader.ReadLine();
            }
        }
    }
}