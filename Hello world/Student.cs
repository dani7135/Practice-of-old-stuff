using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world
{
    class Student
    {
        static public int Count = 0;
        public string Name;
        public int Grade;
        private int phone;
        public Student()
        {

        }
        public Student(string name, int grade, int phone)
        {
            Name = name;
            Grade = grade;
            Phone = phone;
        }
        public int Phone
        {
            set { phone = value; Console.WriteLine(phone); }
        }

    }
}
