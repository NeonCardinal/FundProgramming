//Text Files, Example 001
//30.06.2023, 21:11
using System;
using System.IO;

public class FileReader
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\..\\Texts\\SampleText.txt");

        int lineNumber = 0;

        string line = reader.ReadLine();

        while(line != null)
        {
            lineNumber++;

            Console.WriteLine($"Line {lineNumber}: {line}");

            line = reader.ReadLine();
        }

        reader.Close();
    }
}