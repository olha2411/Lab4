using Pizzeria.Entities;
using Pizzeria.Interfaces;
using System.Text;

namespace Pizzeria.Decorators
{
    public class SideDecorator : BaseDecorator
    {
        private Side _side; 

        public SideDecorator(IOrder order) : base(order) { }

        public void SetSide(Side side)
        {
            _side = side;
        }

        public override decimal CalculatePrice()
        {
            return Order.CalculatePrice() + _side?.Price ?? 0;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(Order.ToString());
            builder.AppendLine(_side.ToString());
            return builder.ToString();
        }
    }
}
