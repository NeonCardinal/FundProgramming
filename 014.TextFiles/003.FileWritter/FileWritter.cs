//Text files, Example 003
//30.06.2023, 21:27
using System;
using System.IO;

public class FileWritter
{
    static void Main()
    {
        StreamWriter writter = new StreamWriter("..//..//..//Test.txt");

        using(writter)
        {
            for(int i = 1; i <= 20; i++)
            {
                writter.WriteLine(i);
            }
        }
    }
}