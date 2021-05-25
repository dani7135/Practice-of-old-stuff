using System;
using System.Collections.Generic;

namespace Hello_world
{
    class Program
    {
        static List<Member> members= new List<Member>();
        static void Main(string[] args)
        {
            PayRoll payRoll = new PayRoll();
            payRoll.PayAll();
            var teacher = new Teacher();
            var student = new Student();
            var p = new Principal();

            var adding = true;
            while (adding)
            {
                try
                {
                    Console.WriteLine(" t or s");
                    var q = Console.ReadLine();
                    if (q == "t")
                    {
                       
                        teacher.Name = Question.Ask("Name: ");
                        teacher.School =(School) Question.AskInt("School name: \n 0: Skole \n 1: Skolen 1 \n 2: Skolerne \n Skriv dit tal her:");
                        teacher.Subject = Question.Ask("Subject: ");
                        teacher.Adresse = Question.Ask("Adresse: ");
                        teacher.Phone = Question.AskInt("Phone: ");
                        members.Add(teacher);


                    }
                    else if (q == "s")
                    {
                        student.Name = Question.Ask("Name: ");
                        student.School = (School)Question.AskInt("School name: \n 0: Skole \n 1: Skolen 1 \n 2: Skolerne \n Skriv dit tal her:");
                        student.Grade = Question.AskInt("Grade: ");
                        student.Adresse = Question.Ask("Adresse: ");
                        student.Phone = Question.AskInt("Phone: ");
                        members.Add(student);
                    }

                    Console.WriteLine("y/n?");
                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                catch(FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {

                    Console.WriteLine("Erro");
                }

          
            }
            
            foreach (var item in members)
            {
                Console.WriteLine("Name: " + item.Name + " " + "Adresse: " + item.Adresse +" "+ "School: " + item.School+ " " + "Phone: " + item.Phone.ToString()); ;
            }
            Exports();

        } 
        static void Exports()
        {
            foreach (var member in members)
            {
                switch (member.School)
                {
                    case School.Hardward:
                        
                        break;
                    case School.Wardhard:
                         break;
                    case School.Dardvard:
                         break;
                }
            }
        }
    }
}




