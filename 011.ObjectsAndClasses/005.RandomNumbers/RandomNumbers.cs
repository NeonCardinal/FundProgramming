//Objects and classes, Task 002
//30.04.2023, 14:50
using System;

public class RandomNumbers
{
    static void Main()
    {
        Random rnd = new Random();

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(rnd.Next(100, 201));
        }
    }
}