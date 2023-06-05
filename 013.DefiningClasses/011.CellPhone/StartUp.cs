//Def classes, Task 008 - 014
//05.06.2023, 14:20

using System;

namespace CellPhone
{
    public class StartUp
    {
        static void Main()
        {
            Gsm huawei = new Gsm("P40 Lite", "Huawei", 500, "Me", new Battery(), new Display());

            Console.WriteLine(huawei.ToString());
        }
    }
}
