//Defining classes, example 007
//09.05.2023, 23:13
using System;

struct Point2D
{
    public Point2D(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public int Y { get; set; }
    public int X { get; set; }
}

class PlayWithPoints
{
    static void PrintPoint(Point2D p) => Console.WriteLine($"({p.X},{p.Y})");

    static void TryToChangePoint(Point2D p)
    {
        p.X++;
        p.Y++;
    }

    static void Main()
    {
        Point2D point = new Point2D(3, -2);

        PrintPoint(point);
        TryToChangePoint(point);
        PrintPoint(point);
    }
}