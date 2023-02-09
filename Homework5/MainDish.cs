namespace Homework5
{
    internal class MainDish : Food
    {
        public MainDish()
        {
        }

        public MainDish(string name, decimal price, double grams) : base(name, price, grams)
        {
            Grams = grams;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} - Grams: {Grams}";
        }
    }
}