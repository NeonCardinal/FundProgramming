﻿//Operators and expressions, Task 005
//03.04.2023, 19:02
using System;

public class TrapeziodArea
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * h / 2;

        Console.WriteLine(area);
    }
}