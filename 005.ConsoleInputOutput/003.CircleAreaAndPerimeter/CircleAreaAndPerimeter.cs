﻿//Console input and output, Task 002
//04.04.2023, 12:39
using System;

public class CircleAreaAndPerimeter
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine($"Area = {area}");
        Console.WriteLine($"Perimeter = {perimeter}");
    }
}