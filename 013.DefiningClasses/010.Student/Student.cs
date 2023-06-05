using System;

namespace Student
{
    public class Student
    {
        private string studentNames;
        private int kurs;
        private string specialnost;
        private string university;
        private string email;
        private long phoneNumber;
        public static int studentCounter = 0;

        public string StudentNames
        {
            get
            { 
                return studentNames; 
            }
            set 
            { 
                studentNames = value; 
            }
        }

        public int Kurs
        {
            get
            {
                return kurs;
            }
            set
            {
                kurs = value;
            }
        }

        public string Specialnost
        {
            get
            {
                return specialnost;
            }
            set
            {
                specialnost = value;
            }
        }

        public string University
        {
            get
            {
                return university;
            }
            set
            {
                university = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public long PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public Student()
        {
            this.studentNames = null;
            this.kurs = 0;
            this.specialnost = null;
            this.university = null;
            this.email = null;
            this.phoneNumber = 0L;
            studentCounter++;
        }

        public Student(string names, int kurs, string specialnost, string university)
        {
            this.studentNames = names;
            this.kurs = kurs;
            this.specialnost = specialnost;
            this.university = university;
            this.email = null;
            this.phoneNumber = 0L;
            studentCounter++;
        }

        public Student(string names, int kurs, string specialnost, string uni, string email, long phoneNumber)
        {
            this.studentNames = names;
            this.kurs = kurs;
            this.specialnost = specialnost;
            this.university = uni;
            this.email = email;
            this.phoneNumber = phoneNumber;
            studentCounter++;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Student names: {this.studentNames}");
            Console.WriteLine($"Student kurs: {Kurs}");
            Console.WriteLine($"Student specialnost: {Specialnost}");
            Console.WriteLine($"Student university: {University}");
            Console.WriteLine($"Student email: {Email}");
            Console.WriteLine($"Student phone number: {PhoneNumber}");
        }
    }
}
