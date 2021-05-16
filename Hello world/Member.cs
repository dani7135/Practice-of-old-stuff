using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world
{
    class Member
    {
        public string Name;
        public string Adresse;
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
