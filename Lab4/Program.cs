using Pizzeria;
using Pizzeria.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Program
    {
        internal static List<IOrder> Orders { get; set; }

        internal static void Main(string[] args)
        {
            Orders = new List<IOrder>();

            var storage = new Storage();
            var maker = new OrderMaker(storage);

            Console.Write("Do you want to add to your order a pizza? [y - yes/n - no] : ");
            var answer = Console.ReadKey();
            Console.WriteLine();

            while (answer.Key == ConsoleKey.Y)
            {
                var item = maker.MakePizza();

                if (item == null) break;

                item = maker.MakeSide(item);
                item = maker.MakeFiller(item);
                item = maker.MakeOption(item);

                Orders.Add(item);   
                Console.WriteLine("\nA pizza was added to your order.\n");

                Console.Write("Do you want to add to your order a pizza? [y - yes/n - no] : ");
                answer = Console.ReadKey();
                Console.WriteLine();
            }


            var writer = new ConsoleWriter();
            writer.WriteOrders();

            Console.ReadKey();
        }
    }
}
