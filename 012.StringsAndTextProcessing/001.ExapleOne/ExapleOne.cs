//Strings and text processing, Exaple 001
//30.04.2023, 18:52
using System;

public class ExapleOne
{
    static void Main()
    {
        string message = "This is a simple string message.";

        Console.WriteLine($"message = {message}");
        Console.WriteLine($"message.Length = {message.Length}");

        for(int i = 0; i < message.Length; i++)
        {
            Console.WriteLine($"message[{i}] = {message[i]}");
        }
    }
}