//Operators and expressions, Demo
//03.04.2023, 18:26
using System;

public class Demo
{
    static void Main()
    {
        Console.WriteLine("Exaple 1");
        DemoOne();

        Console.WriteLine();
        Console.WriteLine("Example 2");
        DemoTwo();

        Console.WriteLine();
        Console.WriteLine("Example 3");
        DemoThree();
    }

    static void DemoOne()
    {
        int a = 7 + 9;

        Console.WriteLine(a);
        Console.WriteLine(a * 3);
        Console.WriteLine(-a);

        string firstName = "Pesho";
        string lastName = "Peshov";
        string fullName = firstName + " " + lastName;
        Console.WriteLine(fullName);
    }

    static void DemoTwo()
    {
        int squarePerimeter = 17;
        double squareSide = squarePerimeter / 4.0;
        double squareArea = squareSide * squareSide;

        Console.WriteLine(squareSide);
        Console.WriteLine(squareArea);

        int a = 5;
        int b = 4;

        Console.WriteLine(a + b);
        Console.WriteLine(a + b++);
        Console.WriteLine(a + b);
        Console.WriteLine(a + (++b));
        Console.WriteLine(a + b);
        Console.WriteLine(14 / a);
        Console.WriteLine(14 % a);

        double dMinusOne = -1.00;
        double dZero = 0.00;
        Console.WriteLine(dMinusOne / dZero);
        Console.WriteLine(1 / dZero);
    }

    static void DemoThree()
    {
        int a = 6;
        int b = 4;
        Console.WriteLine(a > b ? "a > b" : "b <= a");
    }
}