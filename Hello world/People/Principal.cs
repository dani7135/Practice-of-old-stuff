using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world
{
    class Principal : Member, IPay
    {
        public void Pay()
        {
            Console.WriteLine("Paying princial");

        }
    }
}
