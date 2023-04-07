//Console input and output, Demo
//03.04.2023, 23:26
using System;

public class Demo
{
    static void Main()
    {
        Console.WriteLine("Example One:");
        Console.WriteLine();
        ExampleOne();

        Console.WriteLine("==============================");
        Console.WriteLine();
        Console.WriteLine("Example Two:");
        ExampleTwo();

        Console.WriteLine("==============================");
        Console.WriteLine();
        Console.WriteLine("Example Three:");
        ExampleThree();
        Console.WriteLine();

        Console.WriteLine("==============================");
        Console.WriteLine();
        Console.WriteLine("Example Four:");
        ExampleFour();
        Console.WriteLine();

        Console.WriteLine("==============================");
        Console.WriteLine();
        Console.WriteLine("Example Five:");
        ExampleFive();
        Console.WriteLine();

        Console.WriteLine("==============================");
        Console.WriteLine();
        Console.WriteLine("Example Six:");
        ExampleSix();
        Console.WriteLine();

        Console.WriteLine("==============================");
        Console.WriteLine();
        Console.WriteLine("Example Seven:");
        ExampleSeven();
        Console.WriteLine();
    }

    static void ExampleOne()
    {
        Console.Out.WriteLine("Hello World");
    }

    static void ExampleTwo()
    {
        Console.WriteLine("Hello World");
        Console.WriteLine(5);
        Console.WriteLine(3.14159265358979);
    }

    static void ExampleThree()
    {
        Console.WriteLine("I love");
        Console.Write("this ");
        Console.Write("Book!");
    }

    static void ExampleFour()
    {
        string age = "twenty six";
        string text = "He is " + age + " years old.";
        Console.WriteLine(text);

        int ageInt = 26;
        string textTwo = "He is " + ageInt + " years old.";
        Console.WriteLine(textTwo);
    }

    static void ExampleFive()
    {
        string str = "Hello Wolrd!";

        //Print normaly
        Console.WriteLine(str);

        //Print through formatting string
        Console.WriteLine("{0}", str);

        //Print trough string interpolation
        Console.WriteLine($"{str}");
    }

    static void ExampleSix()
    {
        Console.WriteLine("{0, 6}", 123);
        Console.WriteLine("{0, 6}", 1234);
        Console.WriteLine("{0, 6}", 12);
    }

    static void ExampleSeven()
    {
        Console.WriteLine("{0:C2}", 123.456);
        Console.WriteLine("{0:D6}", -1234);
        Console.WriteLine("{0:E2}", 123);
        Console.WriteLine("{0:F2}", -1234.456);
        Console.WriteLine("{0:N2}", 1234567.8);
        Console.WriteLine("{0:P}", 0.456);
        Console.WriteLine("{0:X}", 254);
    }
}