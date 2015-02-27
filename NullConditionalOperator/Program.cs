using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new Pizza();

            bool hasDough = false; ;
            
            if (pizza != null && 
                pizza.IngredientAmounts != null && 
                pizza.IngredientAmounts.ContainsKey("dough"))
            {
                hasDough = true;
            }

            Console.WriteLine($"Has Dough: {hasDough}");

            hasDough = pizza?.IngredientAmounts?.ContainsKey("dough") ?? false;

            Console.WriteLine($"Has Dough: {hasDough}");

            Console.ReadKey();
        }
    }
}
