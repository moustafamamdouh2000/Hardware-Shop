using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Mother_Board_Intel:MotherBoard
    {
        public Mother_Board_Intel(string name,int serial) : base(name, serial) { }
        public override string MB_String(string spec)
        {
            Specs = spec;
            return Specs;
        }
        public override double MB_Price(double price)
        {
            if (price > 100)
            {
                Price = price;
                return Price;
            }
            else
            {
                Console.WriteLine("Enter correct price not less than 100$ !");
                return 0;
            } 
        }
    }
}
