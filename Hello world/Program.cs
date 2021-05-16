using System;
using System.Collections.Generic;

namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            var memeber = new List<Member>();
            var teacher = new Teacher();
            var newmember = new Member();
            var student = new Student();

            var adding = true;
            while (adding)
            {


                Console.WriteLine(" t or s");
                var q = Console.ReadLine();
                if (q == "t")
                {

                    teacher.Name = Question.Ask("Name: ");
                    teacher.Subject = Question.Ask("Subject: ");
                    teacher.Adresse = Question.Ask("Adresse: ");
                    teacher.Phone = int.Parse(Question.Ask("Phone: "));
                    memeber.Add(teacher);


                }
                else if (q == "s")
                {
                    student.Name = Question.Ask("Name: ");
                    student.Grade = int.Parse(Question.Ask("Grade: "));
                    student.Adresse = Question.Ask("Adresse: ");
                    student.Phone = int.Parse(Question.Ask("Phone: "));
                    memeber.Add(student);
                }
            
            Console.WriteLine("y/n?");
            if (Console.ReadLine() != "y")
            {
                adding = false;
            }
            }
            foreach (var item in memeber)
            {
                Console.WriteLine(item.Name + " " + item.Adresse + " " + item.Phone.ToString()); ;
            }
        }
    }
}




