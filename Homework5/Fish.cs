using System.Diagnostics;
using System.Xml.Linq;

namespace Homework5
{
    internal class Fish : MainDish
    {

        public new static double Grams;

        public Fish(string name, decimal price) : base(name, price, Grams)
        {
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} - Grams: {Grams}";
        }
    }
}