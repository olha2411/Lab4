using Pizzeria.Entities;
using Pizzeria.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria.Decorators
{
    public class FillerDecorator : BaseDecorator
    {
        private List<Filler> _fillers;

        public FillerDecorator(IOrder order) : base(order) 
        { 
            _fillers = new List<Filler>();
        }

        public void AddFiller(Filler filler)
        {
            _fillers.Add(filler);
        }

        public override decimal CalculatePrice()
        {
            return Order.CalculatePrice() + _fillers.Sum(f => f.Price);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(Order.ToString());
            foreach(var filler in _fillers)
                builder.AppendLine(filler.ToString());
            return builder.ToString();
        }
    }
}
