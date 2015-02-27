using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedMembers
{
    public class Pizza
    {
        Dictionary<string, float> IngredientAmounts =
            new Dictionary<string, float>
            {
                ["dough"] = 1.2f,
                ["cheese"] = .5f,
                ["sauce"] = .45f
            };

        public decimal Price { get; } = 3.25m;

        public void Add(string newIngredient, float amount) => IngredientAmounts[newIngredient] = amount;

        public string[] Ingredients => IngredientAmounts.Keys.ToArray();

        public float this[string ingredient] => IngredientAmounts[ingredient];

        public static decimal operator +(Pizza x, decimal y) => x.Price + y;

        public static implicit operator float[](Pizza p) => p.IngredientAmounts.Values.ToArray();
    }
}
