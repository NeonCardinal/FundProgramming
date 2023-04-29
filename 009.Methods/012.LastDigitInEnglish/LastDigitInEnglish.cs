//Methods, Task 003
//28.04.2023, 22:32
using System;

public class LastDigitInEnglish
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int lastDigit = number % 10;

        Console.WriteLine($"Last digit is {ToWord(lastDigit)}.");
    }

    static string ToWord(int digit)
    {
        string result = string.Empty;

        switch(digit)
        {
            case 0:
                result = "zero";
                break;
            case 1:
                result = "one";
                break;
            case 2:
                result = "two";
                break;
            case 3:
                result = "three";
                break;
            case 4:
                result = "four";
                break;
            case 5:
                result = "five";
                break;
            case 6:
                result = "six";
                break;
            case 7:
                result = "seven";
                break;
            case 8:
                result = "eight";
                break;
            case 9:
                result = "nine";
                break;
            default:
                Console.WriteLine("Incorrect input!");
                break;
        }

        return result;
    }
}