using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world
{
    class Practices
    {
        /*
     static void Main(string[] args)
        {
            var data = new Data();
            var newdata = new List<Data>();

            data.Name = Que.Ask("Name: ");
            data.Phone = int.Parse(Que.Ask("Number: "));

            newdata.Add(data);
            foreach (var item in newdata)
            {
                Console.WriteLine(item.Name +" " + item.Phone);
            }
        }
       
    }
    class Que { 
        static public string Ask(string question)
        {
            Console.Write(question);
    
            var ting = Console.ReadLine();
            if (ting == "")
            {
                Console.WriteLine("There is nothing. You can't leave it empty!");
                return Console.ReadLine();
            }
            return ting;
        }
    }
    class Data
    {
        public string Name;
        protected int phone;
 
        public Data()
        { }
        public Data(string name, int phone)
        {
            Name = name;
            Phone = phone;
        }
        public int Phone
        {
            set { phone = value; }
            get { return phone; }
        }
    }
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
      }
*/
    }
}
