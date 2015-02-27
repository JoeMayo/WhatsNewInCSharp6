using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexInitializers
{
    class Program
    {
        static void Main()
        {
            var pizza = new Pizza();

            foreach (var key in pizza.IngredientAmounts.Keys)
            {
                Console.WriteLine($"Ingredient: {key}, Amount: {pizza.IngredientAmounts[key]}");
            }

            Console.ReadKey();
        }
    }
}
