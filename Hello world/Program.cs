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
                Console.WriteLine("Name: ");
                newStudent.Name= Console.ReadLine();

                Console.WriteLine("Grade: ");
                newStudent.Grade = int.Parse( Console.ReadLine());

                Console.WriteLine("Phone: ");
                newStudent.Phone =int.Parse(Console.ReadLine());

                students.Add(newStudent);

                Console.WriteLine("y/n?");
                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }
            foreach (var student in students)
            {
                Console.WriteLine(student.Name + " "+ student.Grade );
            }
        }
    }
    class Student
    {
        public string Name;
        public int Grade;
        private int phone;

        public int Phone
        {
            set { phone = value; Console.WriteLine(phone); } 
        }
        public int MyProperty { get; set; }
        
        public void SetPhone(int number)
        {
           phone = number;
             
        }
    }
}



