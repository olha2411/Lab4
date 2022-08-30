using Pizzeria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public class ConsoleWriter
    {
        public void WriteSides(List<Side> sides)
        {
            Console.WriteLine("Sides: ");

            if (sides == null || !sides.Any())
            {
                Console.WriteLine("\tNo one.");
                return;
            }

            for (var i = 0; i < sides.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} - {sides[i]}");
            }

            Console.WriteLine();
        }

        public void WritePizzas(List<Pizza> pizzas)
        {
            Console.WriteLine("Pizzas: ");

            if (pizzas == null || !pizzas.Any())
            {
                Console.WriteLine("\tNo one.");
                return;
            }            

            for (var i = 0; i < pizzas.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} - {pizzas[i]}");
            }

            Console.WriteLine();
        }

        public void WriteOptions(List<Option> options)
        {
            Console.WriteLine("Options: ");

            if (options == null || !options.Any())
            {
                Console.WriteLine("\tNo one.");
                return;
            }

            for (var i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} - {options[i]}");
            }

            Console.WriteLine();
        }

        public void WriteFillers(List<Filler> fillers)
        {
            Console.WriteLine("Fillers: ");

            if (fillers == null || !fillers.Any())
            {
                Console.WriteLine("\tNo one.");
                return;
            }

            for (var i = 0; i < fillers.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} - {fillers[i]}");
            }

            Console.WriteLine();
        }

        public void WriteOrders()
        {
            if (Program.Orders.Any())
                Console.WriteLine("\nYour order: ");
            else 
            { 
                Console.WriteLine("\nYou don't have an order.");
                return;
            }

            for(var i = 0; i< Program.Orders.Count; i++)
            {
                Console.WriteLine($"\tItem {i+1}:");

                var items = Program.Orders[i].ToString().Split('\n');  
                
                foreach(var item in items)
                    Console.WriteLine($"\t\t{item}");

                var price = Program.Orders[i].CalculatePrice();
                Console.WriteLine($"\t\tPrice: {string.Format("{0:0.00}", price)} UAH");
            }

            var totalPrice = Program.Orders.Sum(i => i.CalculatePrice());
            Console.WriteLine($"\n\tTotal price : {string.Format("{0:0.00}", totalPrice)} UAH");
        }
    }
}
