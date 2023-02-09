namespace Homework5
{
    internal class Starter : Food
    {
        public Starter()
        {
        }

        public Starter(string name, decimal price, double grams) : base(name, price, grams)
        {
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} - Grams: {Grams}";
        }
    }
}