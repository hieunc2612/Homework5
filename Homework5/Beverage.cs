using System.Diagnostics;
using System.Xml.Linq;

namespace Homework5
{
    internal class Beverage : Product
    {

        private double milliliters;


        public double Milliliters
        {
            get { return milliliters; }
            set { milliliters = value; }
        }


        public Beverage()
        {

        }
        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            Milliliters = milliliters;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} - Milliliters: {Milliliters}";
        }
    }
}