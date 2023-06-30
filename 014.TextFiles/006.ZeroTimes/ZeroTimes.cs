//Text files, Example 006
//30.06.2023, 22:03
using System;
using System.IO;

public class ZeroTimes
{
    static void Main()
    {
        string fileName = @"C:/Windows/Explorer.exe";
        byte[] bytes = File.ReadAllBytes(fileName);

        int zeroCount = 0;

        foreach(byte b in bytes)
        {
            if(b == 0)
            {
                zeroCount++;
            }
        }

        Console.WriteLine($"Zeroes: {zeroCount}");
    }
}