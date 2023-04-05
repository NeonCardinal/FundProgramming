//Primitive types and variables - lab, Task 007
//03.04.2023, 17:16
using System;

public class StringExample
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        string fullName = firstName + " " + lastName;

        Console.WriteLine($"Hello, {firstName}!");
        Console.WriteLine($"Your full name is {fullName}.");
    }
}