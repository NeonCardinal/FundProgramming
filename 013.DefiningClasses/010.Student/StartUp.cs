//Defining classes, Task 001 - 006
//05.06.2023, 13:09

using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class StartUp
    {
        static void Main()
        {
            Student empty = new Student();
            Student canka = new Student("Canka Petrova Petrova", 3, "Informatika", "TU");
            Student kirilka = new Student("Kirilka Atanasova Goncheva", 1, "Informatika", "PU", "Kirilka@kiki.com", 0888123456L);

            empty.StudentInfo();
            canka.StudentInfo();
            kirilka.StudentInfo();

            Console.WriteLine($"Broi studenti: {Student.studentCounter}");
        }
    }
}
