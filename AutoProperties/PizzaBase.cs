using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    public abstract class PizzaBase
    {
        public string Name { get; protected set; } = "Cheeze";

        public List<string> Ingredients { get; } = new List<string> { "dough", "sauce", "cheese" };

        public virtual decimal Price { get; set; } = 3.00m;

        public PizzaBase(IEnumerable<string> extraIngredients)
        {
            Ingredients.AddRange(extraIngredients);
        }
    }
}
