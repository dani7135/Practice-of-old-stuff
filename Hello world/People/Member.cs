using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world
{
    enum School
    {
        Hardward = 0,
        Wardhard = 1,
        Dardvard = 2
    }
    class Member
    {
        public string Name;
        public string Adresse;
        public School School;
        protected int phone;
        static public int Count = 0;

        public Member()
        { }
        public Member(string name, int phone)
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
}
