using Pizzeria.Entities;
using Pizzeria.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria.Decorators
{
    public class OptionDecorator : BaseDecorator
    {
        private List<Option> _options;

        public OptionDecorator(IOrder order) : base(order) 
        { 
            _options = new List<Option>();
        }

        public void AddOption(Option option)
        {
            _options.Add(option);
        }

        public override decimal CalculatePrice()
        {
            return Order.CalculatePrice() + _options.Sum(o => o.Price);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(Order.ToString());
            foreach (var option in _options)
                builder.AppendLine(option.ToString());
            return builder.ToString();
        }
    }
}
