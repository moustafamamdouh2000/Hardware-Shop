using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    abstract class Person
    {
        protected string UserName;
        protected int ID;
        public Person(string name,int ID)
        {
            UserName = name;
            this.ID = ID;
        }
    }
}
