//Objects and classes, Example 003
//30.04.2023, 13:34
using System;
using System.Text;

public class RandomPasswordGenerator
{
    private const string CapitalLetters =
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string SmallLetters =
        "abcdefghijklmnopqrstuvwxyz";
    private const string Digits = "0123456789";
    private const string SpecialChars =
        "~!@#$%^&*()_+='{}[]\\|`:;.,/?<>";
    private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;
    private static Random rnd = new Random();

    static void Main()
    {
        StringBuilder password = new StringBuilder();

        for(int i = 1; i <= 2; i++)
        {
            char capitalLetter = GenerateChar(CapitalLetters);
            InsertAtRandomPos(password, capitalLetter);
        }

        for(int i = 1; i <= 2; i++)
        {
            char smallLetter = GenerateChar(SmallLetters);
            InsertAtRandomPos(password, smallLetter);
        }

        char digit = GenerateChar(Digits);
        InsertAtRandomPos(password, digit);

        for(int i = 1; i <= 3; i++)
        {
            char specialChar = GenerateChar(SpecialChars);
            InsertAtRandomPos(password, specialChar);
        }

        int count = rnd.Next(8);
        for(int i = 1; i <= count; i++)
        {
            char specialChar = GenerateChar(AllChars);
            InsertAtRandomPos(password, specialChar);
        }

        Console.WriteLine(password);
    }

    static void InsertAtRandomPos(StringBuilder pass, char ch)
    {
        int randomPos = rnd.Next(pass.Length + 1);
        pass.Insert(randomPos, ch);
    }

    static char GenerateChar(string str)
    {
        int randomPos = rnd.Next(str.Length);
        char randomChar = str[randomPos];

        return randomChar;
    }
}