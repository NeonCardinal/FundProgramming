//Strings and text processing, Example 003
//01.05.2023, 19:30
using System;

public class ToLowerAndToUpper
{
    static void Main()
    {
        string text = "All Kind OF LeTTers";

        Console.WriteLine(text.ToLower());

        string pass1 = "Parola";
        string pass2 = "PaRola";
        string pass3 = "parola";

        Console.WriteLine(pass1.ToUpper() == "PAROLA");
        Console.WriteLine(pass2.ToUpper() == "PAROLA");
        Console.WriteLine(pass3.ToUpper() == "PAROLA");
    }
}