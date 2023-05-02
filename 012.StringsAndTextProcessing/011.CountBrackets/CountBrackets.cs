//Strings and text processing, Task 003
//02.05.2023, 17:23
using System;

public class CountBrackets
{
    static void Main()
    {
        string text = "((a + b) / 5 - d)";

        int counter = 0;

        for(int i = 0; i < text.Length; i++)
        {
            char symbol = text[i];
            if(symbol == '(')
            {
                counter++;
            }
            else if(symbol == ')')
            {
                counter--;
            }
        }

        if(counter != 0)
        {
            Console.WriteLine("Incorrect");
        }
        else
        {
            Console.WriteLine("Correct");
        }
    }
}