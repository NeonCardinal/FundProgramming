using System;

public class Kid
{
    public void CallTheDog(Dog dog)
    {
        Console.WriteLine($"Come, {dog.Name}");
    }

    public void WagTheDog(Dog dog)
    {
        dog.Bark();
    }
}