//Defining classes, Example 002
//04.05.2023, 22:06
using System;
using System.Xml.XPath;

public class OverlappingScope
{
    int myValue = 3;

    void PrintMyValue()
    {
        int myValue = 5;

        Console.WriteLine($"My value is: {this.myValue}");
    }

    int CalculateNewValue(int newValue)
    {
        int result = myValue + newValue;

        return result;
    }

    static void Main()
    {
        OverlappingScope instance = new OverlappingScope();
        instance.PrintMyValue();
    }
}