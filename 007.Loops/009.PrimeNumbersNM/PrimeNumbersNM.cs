//Loops, Task 009
//08.04.2023, 21:18
using System;

public class PrimeNumbersNM
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());

        for(int i = n; i <= m; i++)
        {
            bool prime = true;
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(i);

            while(divider <= maxDivider)
            {
                if(i % divider == 0)
                {
                    prime = false;
                    break;
                }

                divider++;
            }

            if(prime)
            {
                Console.WriteLine($" {i}");
            }
        }
    }
}