using System;

public class Dog
{
    private string name = "Sharo";

    public string Name
    {
        get;
        set;
    }

    public void Bark()
    {
        Console.WriteLine("wow-wow");
    }

    public void DoSth()
    {
        this.Bark();
    }
}