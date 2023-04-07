//Console input and output, Task 003
//04.04.2023, 12:45
using System;

public class FirmAndManager
{
    static void Main()
    {
        string firmName = Console.ReadLine();
        string firmAddress = Console.ReadLine();
        int firmPhone = int.Parse(Console.ReadLine());
        int firmFax = int.Parse(Console.ReadLine());
        string firmWebSite = Console.ReadLine();

        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerPhone = int.Parse(Console.ReadLine());

        string managerFullName = managerFirstName + " " + managerLastName;

        Console.WriteLine("Firm data:");
        Console.WriteLine($"Firm name: {firmName}");
        Console.WriteLine($"Firm address: {firmAddress}");
        Console.WriteLine($"Firm phone number: {firmPhone}");
        Console.WriteLine($"Firm fax number: {firmFax}");
        Console.WriteLine($"Firm web site: {firmWebSite}");
        Console.WriteLine($"Firm manager: {managerFullName}");
        Console.WriteLine($"Manager phone number: {managerPhone}");
    }
}