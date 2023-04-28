//Methods, Example 002
//26.04.2023, 00:51
using System;

public class PrintSign
{
    static void Main()
    {
        Console.Write("Vyvedete cqlo chislo: ");
        int n = int.Parse(Console.ReadLine());

        PSign(n);
    }

    static void PSign(int number)
    {
        if(number > 0)
        {
            Console.WriteLine("Positive");
        }
        else if(number < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}