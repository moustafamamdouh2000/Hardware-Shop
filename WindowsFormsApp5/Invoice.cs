using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Invoice
    {
        double price, quan;
        public Invoice() { }
        public double Invoicee(User user,Component comp)
        {
            if(user is Normal_User)
            {
                Normal_User x = user as Normal_User;
                if(comp is Rams)
                {
                    Rams z = comp as Rams;
                    price = x.DiscounT * z.PRice;
                }
                else if (comp is GPU)
                {
                    GPU z = comp as GPU;
                    price = x.DiscounT * z.PRice;
                }
                else
                {
                    MotherBoard z = comp as MotherBoard;
                    price = x.DiscounT * z.PRice;
                }

            }
            return price;
        }
    }
}
