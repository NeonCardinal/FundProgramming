//Defining classes, Example 009
//05.06.2023, 12:47
using FirstExample;
using System;


public class AnimalsShelterTest
{
    static void Main()
    {
        AnimalsShelter<Dog> shelter = new AnimalsShelter<Dog>();

        shelter.Shelter(new Dog());

        Dog d = shelter.Release(0);
        Console.WriteLine(d);
        d.Bark();
    }
}