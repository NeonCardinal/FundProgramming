//Defining classes, Example 009
//05.06.2023, 12:30
using System;

public class AnimalsShelter<T>
{
    private const int DefaultPlacesCount = 20;

    private T[] animalList;
    private int usedPlaces;

    public AnimalsShelter() : this(DefaultPlacesCount)
    {

    }

    public AnimalsShelter(int placesCount)
    {
        this.animalList = new T[placesCount];
        this.usedPlaces = 0;
    }

    public void Shelter(T newAnimal)
    {
        if(this.usedPlaces >= this.animalList.Length)
        {
            throw new InvalidOperationException("Shelter is full.");
        }

        this.animalList[this.usedPlaces] = newAnimal;
        this.usedPlaces++;
    }

    public T Release(int index)
    {
        if (index < 0 || index >= this.usedPlaces)
        {
            throw new ArgumentOutOfRangeException("Invalid cell index: " + index);
        }

        T realeasedAnimal = this.animalList[index];

        for (int i = index; i < this.usedPlaces - 1; i++)
        {
            this.animalList[i] = this.animalList[i + 1];
        }

        this.animalList[this.usedPlaces - 1] = default(T);
        this.usedPlaces--;

        return realeasedAnimal;
    }
}