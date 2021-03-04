using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class User: Person
    {
        protected double Discount;
        public User(string name,int id) : base(name, id)
        {

        }
    }
    class Normal_User:User
    {
        public Normal_User(string name,int id,double discount) : base(name, id)
        {
            
        }
        public double DiscounT
        {
            set { if (value < 0.2 && value > 0.0) { Discount = value; } }
            get { return Discount;  }
        }
    }
    class VIP_User:User
    {
        public VIP_User(string name, int id, double discount) : base(name, id)
        {

        }
        public double DiscounT
        {
            set { if (value < 0.7 && value > 0.2) { Discount = value; } }
            get { return Discount; }
        }
    }
}
