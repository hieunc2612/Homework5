    namespace Homework5
{
    internal class ColdBeverage : Beverage
    {
        public ColdBeverage()
        {

        }
        public ColdBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} - Milliliters: {Milliliters}";
        }
    }
}