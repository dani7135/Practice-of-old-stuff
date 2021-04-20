using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world
{
    public class Question
    {
        static public string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
