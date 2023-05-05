using System.Runtime.CompilerServices;

public class Point
{
    private double x;
    private double y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double X
    {
        get { return x; }
        set { this.x = value; }
    }

    public double Y
    {
        get { return y; }
        set { this.y = value; }
    }
}