//Conditional statements, Task 008
//07.04.2023, 21:35
using System;

public class PlayWithSwitch
{
    static void Main()
    {
        string cmd = Console.ReadLine();

        switch(cmd)
        {
            case "int":
                {
                    int number = int.Parse(Console.ReadLine());
                    number += 1;
                    Console.WriteLine(number);
                }
                break;
            case "double":
                {
                    double number = double.Parse(Console.ReadLine());
                    number += 1;
                    Console.WriteLine(number);
                }
                break;
            case "string":
                {
                    string str = Console.ReadLine();
                    str += "*";
                    Console.WriteLine(str);
                }
                break;
            default:
                Console.WriteLine("Wrong input!");
                break;
        }
    }
}