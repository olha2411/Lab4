using Pizzeria;
using Pizzeria.Decorators;
using Pizzeria.Interfaces;
using System;
using System.Linq;

namespace Lab4
{
    public class OrderMaker
    {
        private readonly Storage _storage;
        private readonly ConsoleWriter _writer;
        private readonly ConsoleReader _reader;

        public OrderMaker(Storage storage)
        {
            _storage = storage;
            _reader = new ConsoleReader();
            _writer = new ConsoleWriter();
        }

        public IOrder MakePizza()
        {
            _writer.WritePizzas(_storage.Pizzas);
            var key = _reader.ReadAnswer("pizza", _storage.Pizzas.Count);

            if(key == 0) return null;

            var pizza =  _storage.Pizzas?.ElementAt(key - 1);
            Console.WriteLine();

            return new DefaultOrder(pizza);
        }

        public IOrder MakeSide(IOrder item)
        {
            Console.WriteLine();
            Console.Write("Do you want to choose a side? [y - yes/n - no] : ");
            var answer = Console.ReadKey();

            Console.WriteLine();

            if (answer.Key != ConsoleKey.Y) return item;

            _writer.WriteSides(_storage.Sides);
            var key = _reader.ReadAnswer("side", _storage.Sides.Count);

            if(key == 0) return item;

            var side = _storage.Sides.ElementAt(key - 1);

            var sideItem = new SideDecorator(item);

            sideItem.SetSide(side);

            return sideItem;
        }

        public IOrder MakeFiller(IOrder item)
        {
            Console.WriteLine();
            Console.Write("Do you want to choose a filler? [y - yes/n - no] : ");
            var answer = Console.ReadKey();
            Console.WriteLine();

            if (answer.Key != ConsoleKey.Y) return item;

            var fillers = _storage.Fillers;

            _writer.WriteFillers(fillers);
            var key = _reader.ReadAnswer("filler", fillers.Count);
            Console.WriteLine();

            if (key == 0) return item;

            var fillerItem = new FillerDecorator(item);

            while (key != 0)
            {
                var filler = fillers.ElementAt(key - 1);

                fillerItem.AddFiller(filler);
                fillers.Remove(filler);

                _writer.WriteFillers(fillers);
                key = _reader.ReadAnswer("filler", fillers.Count);
                Console.WriteLine();
            }

            return fillerItem;
        }

        public IOrder MakeOption(IOrder item)
        {
            Console.WriteLine();
            Console.Write("Do you want to choose an option? [y - yes/n - no] : ");
            var answer = Console.ReadKey();

            Console.WriteLine();

            if (answer.Key != ConsoleKey.Y) return item;

            var options = _storage.Options;

            _writer.WriteOptions(options);
            var key = _reader.ReadAnswer("option", options.Count);
            Console.WriteLine();

            if (key == 0) return item;

            var optionItem = new OptionDecorator(item);

            while (key != 0)
            {
                var option = options.ElementAt(key - 1);

                optionItem.AddOption(option);
                options.Remove(option);

                _writer.WriteOptions(options);
                key = _reader.ReadAnswer("option", options.Count);
                Console.WriteLine();
            }

            return optionItem;
        }
    }
}
