//Strings and text processing, Task 005
//02.05.2023, 17:43
using System;

public class CntWordInText
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".ToLower();
        string keyWord = "in";
        int counter = 0;

        int index = text.IndexOf(keyWord);

        while(index != -1) 
        {
            counter++;
            index = text.IndexOf(keyWord, index + 1);
        }

        Console.WriteLine(counter);
    }
}