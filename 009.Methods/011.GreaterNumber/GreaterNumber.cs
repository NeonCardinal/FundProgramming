//Methods, Task 002
//28.04.2023, 22:24
using System;

public class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine($"The greater number is: {GetMax(first, second)}");
    }

    static int GetMax(int first, int second)
    {
        int greater = 0;

        if(first > second)
        {
            greater = first;
        }
        else
        {
            greater = second;
        }

        return greater;
    }
}