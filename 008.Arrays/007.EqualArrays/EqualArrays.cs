//Arrays, Task 007
//25.04.2023, 21:38
using System;

public class EqualArrays
{
    static void Main()
    {
        Console.Write("Vuvedete stoinost za n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Vuvedete stoinost za m: ");
        int m = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[m];

        for(int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < m; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        bool isEqual = true;

        if(n != m)
        {
            isEqual = false;
        }
        else
        {
            for(int i = 0; i < n; i++)
            {
                if(firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                    break;
                }
                else
                {
                    isEqual = true;
                }
            }
        }

        if(isEqual)
        {
            Console.WriteLine("Ednakvi sa.");
        }
        else
        {
            Console.WriteLine("Ne sa ednakvi");
        }
    }
}