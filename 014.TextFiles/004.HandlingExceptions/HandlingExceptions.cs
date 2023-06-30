//Text files, Example 004
//30.06.2023, 21:31
using System;
using System.IO;

public class HandlingExceptions
{
    static void Main()
    {
        string fileName = @"../../../Test.txt";

        try
        {
            StreamReader reader = new StreamReader(fileName);
            Console.WriteLine($"File {fileName} successfully opened.");
            Console.WriteLine("File contents");

            using(reader)
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch(FileNotFoundException)
        {
            Console.Error.WriteLine($"Can not find file {fileName}");
        }
        catch(DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Invalid directory in the file path.");
        }
        catch(IOException)
        {
            Console.Error.WriteLine($"Can not open the file {fileName}");
        }
    }
}