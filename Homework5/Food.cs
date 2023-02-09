namespace Homework5
{
    internal class Food : Product
    {

        private double grams;

        public double Grams
        {
            get { return grams; }
            set { grams = value; }
        }

        public Food()
        {
        }

        public Food(string name, decimal price, double grams) : base(name, price)
        {
            Grams = grams;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} - Grams: {Grams}";
        }
    }
}