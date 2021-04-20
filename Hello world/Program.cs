using System;
using System.Collections.Generic;

namespace Hello_world 
{
    class Program 
    {
        /*
        static void Main(string[] args)
        {            
            Console.WriteLine("Text 1");      
            var a  = Funk1();
            Console.WriteLine("Text 2");
            var b = Funk1();
            Console.WriteLine("Text 3");
            var c = Funk1();
        }
        static string Funk1()
        {
            var ting = Console.ReadLine();
            if (ting == "")
            {               
                    Console.WriteLine("There is nothing. You can't leave it empty!");
                    return Console.ReadLine();            
            }
            return ting;
        }*/
        /*static void Main(string[] args)
          {
              Console.WriteLine("Write a number between 0 of 10");
              int num = int.Parse( Console.ReadLine());
              switch (num)
              {
                  case 0:
                      Console.WriteLine("lla");
                      break;
                  case 1:
                      Console.WriteLine("ksj");
                      break;
                  case 2:
                      Console.WriteLine("nono");
                      break;

                  default:
                      Console.WriteLine("Too high");
                      break;
              }
          }*/
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
    class Student
    {
        static public int Count = 0;
        public string Name;
        public int Grade;
        private int phone;

        public int Phone
        {
            set { phone = value; Console.WriteLine(phone); } 
        }

   
    }
}



