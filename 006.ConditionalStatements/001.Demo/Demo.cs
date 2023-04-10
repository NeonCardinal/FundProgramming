//Conditional statements, Demo
//04.04.2023, 14:15
using System;

public class Demo
{
    static void Main()
    {
        Console.WriteLine("Example 1:");
        Console.WriteLine();
        ExampleOne();
        Console.WriteLine();
        Console.WriteLine("=======================");
        Console.WriteLine();

        Console.WriteLine("Example 2:");
        Console.WriteLine();
        ExampleTwo();
        Console.WriteLine();
        Console.WriteLine("=======================");
        Console.WriteLine();

        Console.WriteLine("Example 3:");
        Console.WriteLine();
        ExampleThree();
        Console.WriteLine();
        Console.WriteLine("=======================");
        Console.WriteLine();

        Console.WriteLine("Example 4:");
        Console.WriteLine();
        ExampleFour();
        Console.WriteLine();
        Console.WriteLine("=======================");
        Console.WriteLine();
    }

    static void ExampleOne()
    {
        Console.WriteLine("Enter two numbers.");

        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int biggerNumber = firstNumber;

        if (secondNumber > firstNumber)
        {
            biggerNumber = secondNumber;
        }

        Console.WriteLine($"The bigger number is: {biggerNumber}");
    }

    static void ExampleTwo()
    {
        int x = 2;

        if (x > 3)
        {
            Console.WriteLine("x is greater than 3");
        }
        else
        {
            Console.WriteLine("x is not greater than 3");
        }
    }

    static void ExampleThree()
    {
        int first = 5;
        int second = 3;

        if (first == second)
        {
            Console.WriteLine("These two numbers are equal.");
        }
        else
        {
            if (first > second)
            {
                Console.WriteLine("The first number is greater.");
            }
            else
            {
                Console.WriteLine("The second number is greater.");
            }
        }
    }

    static void ExampleFour()
    {
        char ch = 'X';

        if(ch == 'a' || ch == 'A')
        {
            Console.WriteLine("Vowel [ei]");
        }
        else if(ch == 'e' || ch == 'E')
        {
            Console.WriteLine("Vowel [i:]");
        }
        else if(ch == 'i' || ch == 'I')
        {
            Console.WriteLine("Vowel [ai]");
        }
        else if(ch == 'o' || ch == 'O')
        {
            Console.WriteLine("Vowel [ou]");
        }
        else if(ch == 'u' || ch == 'U')
        {
            Console.WriteLine("Vowel [ju:]");
        }
        else
        {
            Console.WriteLine("Consonant");
        }
    }
}