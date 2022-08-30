namespace Pizzeria.Entities
{
    public class Option
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - costs {string.Format("{0:0.00}", Price)} UAH";
        }
    }
}
