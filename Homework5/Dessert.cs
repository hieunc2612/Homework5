using System.Diagnostics;
using System.Xml.Linq;

namespace Homework5
{
    internal class Dessert : Food
    {

        private double calories;

        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }


        public Dessert()
        {
        }

        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            Calories = calories;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} - Grams: {Grams} - Calories: {Calories}";
        }
    }
}