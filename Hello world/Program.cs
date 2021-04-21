using System;
using System.Collections.Generic;

namespace Hello_world 
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            var students = new List<Student>();
            var adding = true;
            while (adding)
            {
                var newStudent = new Student();

                newStudent.Name = Question.Ask("Name: ");
                newStudent.Grade = int.Parse(Question.Ask("Grade: "));               
                newStudent.Phone = int.Parse(Question.Ask("Phonenr: "));

                students.Add(newStudent);

                Student.Count++;
                Console.WriteLine(Student.Count);
                
                Console.WriteLine("y/n?");
                if (Console.ReadLine() != "y") 
                {
                    adding = false;
                }
            }
            foreach (var student in students)
            {
                Console.WriteLine(student.Name + " "+ student.Grade  );
            }
        }     
    }
}



