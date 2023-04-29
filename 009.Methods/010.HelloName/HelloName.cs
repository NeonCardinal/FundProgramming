//Methods, Task 001
//28.04.2023, 22:21
using System;

public class HelloName
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Greetings(name);
    }

    static void Greetings(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}