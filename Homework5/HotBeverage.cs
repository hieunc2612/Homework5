namespace Homework5
{
    internal class HotBeverage : Beverage
    {
        public HotBeverage()
        {

        }
        public HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} - Milliliters: {Milliliters}";
        }
    }
}