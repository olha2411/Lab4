using Pizzeria.Entities;
using Pizzeria.Interfaces;

namespace Pizzeria
{
    public class DefaultOrder : IOrder
    {
        private readonly Pizza _pizza;

        public DefaultOrder(Pizza pizza)
        {
            _pizza = pizza;
        }

        public decimal CalculatePrice()
        {
            return _pizza?.Price ?? 0;
        }

        public override string ToString()
        {
            return $"{_pizza}\n";
        }
    }
}
