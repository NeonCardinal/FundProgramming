//Defining classes, Example 005
//05.05.2023, 23:32
using System;

public class Rectangle
{
    private float height;
    private float width;

    public Rectangle(float height, float width)
    {
        this.height = height;
        this.width = width;
    }

    public float Area
    {
        get { return height * width; }
    }
}

public class TestClass
{
    static void Main()
    {
        Rectangle myRectangle = new Rectangle(2.5f, 4.1f);

        Console.WriteLine(myRectangle.Area);
    }
}