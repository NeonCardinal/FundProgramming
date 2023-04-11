//Loops, Task 003
//07.04.2023, 22:26
using System;

public class PrimeNumberWhile
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");

        int number = int.Parse(Console.ReadLine());
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(number);
        bool prime = true;

        while(prime && (divider <= maxDivider))
        {
            if(number % divider == 0)
            {
                prime = false;
            }

            divider++;
        }

        Console.WriteLine($"Prime? {prime}");
    }
}