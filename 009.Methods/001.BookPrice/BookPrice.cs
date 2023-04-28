//Methods, Example 001
//26.04.2023, 00:48
using System;

public class BookPrice
{
    static void Main()
    {
        decimal[] prices = { 12.01M, 1.19M, 3.14M };

        PrintTotalAmountForBooks(prices);
    }

    static void PrintTotalAmountForBooks(decimal[] prices)
    {
        decimal totalAmount = 0;

        foreach(decimal price in prices)
        {
            totalAmount += price;
        }

        Console.WriteLine($"The total amoung of all book is : {totalAmount:F2}");
    }
}