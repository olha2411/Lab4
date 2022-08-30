namespace Pizzeria.Entities
{
    public class Filler
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Grams { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Grams}g) - costs {string.Format("{0:0.00}", Price)} UAH";
        }
    }
}
