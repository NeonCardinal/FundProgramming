//Methods, Example 006
//28.04.2023, 21:16
using System;

public class TemperatureConverter
{
    static void Main()
    {
        Console.Write("Enter your body temperature in Fahrenheit degrees: ");
        double temperature = double.Parse(Console.ReadLine());

        temperature = ConvertFahrenheitToCelsius(temperature);

        Console.WriteLine($"Your body temperature in Celsius degrees is: {temperature}");

        if(temperature >= 37)
        {
            Console.WriteLine("You are ill!");
        }
    }

    static double ConvertFahrenheitToCelsius(double temperature)
    {
        double tempC = (temperature - 32) * 5 / 9;

        return tempC;
    }
}