using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world
{
    interface IPay
    {
        void Pay();
    }
    public class PayRoll
    {
          List<IPay> pays = new List<IPay>();
        public PayRoll() 
        {
            pays.Add(new Teacher());
            pays.Add(new Principal());
        }
        public void PayAll()
        {
            foreach (var item in pays)
            {
                item.Pay();
            }
        }
    }
}
