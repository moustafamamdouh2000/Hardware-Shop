using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    abstract class Component
    {
        protected string Name;
        protected string    Serial_Number;
        protected double Price;
        protected string Specs;
        protected string Manufacture;
        public Component(string name,string serial_num,string Manufacture)
        {
            Name = name;
            Serial_Number = serial_num;
            this.Manufacture = Manufacture;
        }
        public abstract double PRICE(double value);
    }
    class MotherBoard : Component
    {
        public MotherBoard(string name, string serial, string Manufacture) : base(name, serial, Manufacture) { }
        public override double PRICE(double value)
        {
            if (value > 10.0)
                Price = value;
            else
                Price = 0;
            return Price;
        }
        public double PRice
        {
            get { return Price; }
        }
    }
    class Rams : Component
    {
        public Rams(string name, string serial, string manufacture) : base(name, serial, manufacture) { }
        public override double PRICE(double value)
        {
            if (value > 10.0)
                Price = value;
            else
                Price = 0;
            return Price;
        }
        public double PRice
        {
            get { return Price; }
        }
    }
    class GPU : Component
    {
        public GPU(string name, string serial, string Manufacture) : base(name, serial, Manufacture) { }
        public override double PRICE(double value)
        {
            if (value > 10.0)
                Price = value;
            else
                Price = 0;
            return Price;
        }
        public double PRice
        {
            get { return Price; }
        }
    }
}
