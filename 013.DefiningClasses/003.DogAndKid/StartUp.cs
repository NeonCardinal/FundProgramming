//Defining classes, Example 003
//04.05.2023, 22:46
using System;

public class OverlappingScope
{
    static void Main()
    {
        Dog dog = new Dog();

        Kid kid = new Kid();

        dog.Name = "Sharo";
        dog.DoSth();
        dog.Bark();

        kid.CallTheDog(dog);
        kid.WagTheDog(dog);
    }
}