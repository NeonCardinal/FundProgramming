//Conditional statements, Task 002
//04.04.2023, 14:40
using System;

public class PlusOrMinus
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int cnt = 0;

        if (a < 0)
        {
            cnt++;
        }
        else
        {
            cnt--;
        }
        if (b < 0)
        {
            cnt++;
        }
        else
        {
            cnt--;
        }
        if (c < 0)
        {
            cnt++;
        }
        else
        {
            cnt--;
        }

        if (cnt % 2 == 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}