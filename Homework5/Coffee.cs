using System.Diagnostics;
using System.Xml.Linq;

namespace Homework5
{
    internal class Coffee : HotBeverage
    {

        public double CoffeeMilliliters = 50;
        public decimal CoffeePrice = 3.5m;

        public double Caffeine { get; set; }

        public Coffee()
        {
        }

        public Coffee(string name, decimal price, double milliliters, double coffeeMilliliters, decimal coffeePrice, double caffeine) : base(name, price, milliliters)
        {
            Caffeine = caffeine;
        }

        public Coffee(string name, decimal price, double milliliters, double caffeine) : base(name, price, milliliters)
        {
            Caffeine = caffeine;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} - Milliliters: {Milliliters} - Caffeine: {Caffeine}";
        }
    }
}