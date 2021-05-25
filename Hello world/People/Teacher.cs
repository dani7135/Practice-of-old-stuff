using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world
{
    class Teacher : Member, IPay
    {
        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
        public string Subject;
        public Teacher()
        { }
        public Teacher(string subject)
        {
            Subject = subject;
        }

    }
}
