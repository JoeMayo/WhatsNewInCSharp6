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

            var prog = new Program();
            prog.SimulateSomethingHappened();
            prog.SomethingHappened += Prog_SomethingHappened;
            prog.SimulateSomethingHappened();

            Console.ReadKey();
        }

        private void SimulateSomethingHappened()
        {
            SomethingHappened?.Invoke(this, new EventArgs());
        }

        private static void Prog_SomethingHappened(object sender, EventArgs e)
        {
            Console.WriteLine("Something Happened.");
        }

        public event EventHandler SomethingHappened;
    }
}
