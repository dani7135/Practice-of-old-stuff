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
        static public string Ask(int question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
        static public int AskInt(string question)
        {
            try
            {
                Console.Write(question);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw new FormatException("Input not a number");
            }
            
        }
    }
}
