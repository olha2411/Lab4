using Pizzeria.Interfaces;

namespace Pizzeria.Decorators
{
    public class BaseDecorator : IOrder
    {
        protected readonly IOrder Order;

        public BaseDecorator(IOrder order)
        {
            Order = order;
        }

        public virtual decimal CalculatePrice()
        {
            return Order.CalculatePrice();
        }

        public override string ToString()
        {
            return Order?.ToString();
        }
    }
}
