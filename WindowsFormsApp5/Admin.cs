using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Admin : Person
    {
        string Password;
        public Admin(string name, int id,string Password) : base(name, id)
        {
            this.Password = Password;
        }
    }
}
