using Pizzeria.Entities;
using System.Collections.Generic;

namespace Pizzeria
{
    public class Storage
    {
        public List<Side> Sides => new List<Side>()
        {
            new Side()
            {
                Name = "Sesame side",
                Price = 8.8m
            },
            new Side()
            {
                Name = "Hunting side",
                Price = 34.4m
            },
            new Side()
            {
                Name = "Cheese side",
                Price = 31.2m
            },
        };

        public List<Filler> Fillers => new List<Filler>()
        {
            new Filler()
            {
                Name = "Mushrooms",
                Price = 14.4m,
                Grams = 50
            },
            new Filler()
            {
                Name = "Tomatoes",
                Price = 13.6m,
                Grams = 50
            },
            new Filler()
            {
                Name = "Olives",
                Price = 16,
                Grams = 50
            },
            new Filler()
            {
                Name = "Chili pepper",
                Price = 19.7m,
                Grams = 5
            },
            new Filler()
            {
                Name = "Lemon",
                Price = 12,
                Grams = 50
            },
        };

        public List<Option> Options => new List<Option>()
        {
            new Option()
            {
                Name = "Cutlery",
                Price = 15
            },

            new Option()
            {
                Name = "Napkins",
                Price = 5
            }
        };

        public List<Pizza> Pizzas => new List<Pizza>()
        {
            new Pizza()
            {
                Name = "Manhattan",
                Price = 210
            },
            new Pizza()
            {
                Name = "Texas",
                Price = 225
            },
            new Pizza()
            {
                Name = "Chicken-Dorblyu",
                Price = 239
            },
            new Pizza()
            {
                Name = "Grill Mix",
                Price = 310
            },
            new Pizza()
            {
                Name = "Carbonara",
                Price = 261
            },
        };
    }
}
