//Text files, Example 005
//30.06.2023, 21:47
using System;
using System.IO;

public class CountingWordOccurrences
{
    static void Main()
    {
        string fileName = @"../../../sample.txt";
        string word = "C#";

        try
        {
            StreamReader reader = new StreamReader(fileName);

            using(reader)
            {
                int occurrences = 0;
                string line = reader.ReadLine();

                while(line != null)
                {
                    int index = line.IndexOf(word);

                    while(index != -1)
                    {
                        occurrences++;
                        index = line.IndexOf(word, (index + 1));
                    }

                    line = reader.ReadLine();
                }

                Console.WriteLine($"The word {word} occurs {occurrences} times.");
            }
        }
        catch(FileNotFoundException)
        {
            Console.Error.WriteLine($"Can not find file {fileName}.");
        }
        catch(IOException)
        {
            Console.Error.WriteLine($"Can not read the file {fileName}.");
        }
    }
}