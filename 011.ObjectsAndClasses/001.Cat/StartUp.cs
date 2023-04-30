//Objects and classes, Exaple 001
//30.04.2023, 12:56
using System;

namespace _001.Cat
{
    public class StartUp
    {
        static void Main()
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tony";
            firstCat.SayMeow();

            Cat secondCat = new Cat("Pepy", "Red");
            secondCat.SayMeow();
            Console.WriteLine($"Cat {secondCat.Name} is {secondCat.Color}");

            Cat thirdCat = new Cat();
            thirdCat.SayMeow();
        }
    }
}
