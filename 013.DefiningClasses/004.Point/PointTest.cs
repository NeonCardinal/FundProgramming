//Defining classes, Example 004
//05.05.2023, 23:17
using System;

public class PointTest
{
    static void Main()
    {
        Point myPoint = new Point(1, 2);

        double myPointXCoordinate = myPoint.X;
        double myPointYCoordinate = myPoint.Y;

        Console.WriteLine($"The X coordinate: {myPointXCoordinate}");
        Console.WriteLine($"The Y coordinate: {myPointYCoordinate}");
    }
}