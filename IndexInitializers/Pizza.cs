using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexInitializers
{
    public class Pizza
    {
        public Dictionary<string, float> IngredientAmounts =
            new Dictionary<string, float>
            {
                ["dough"] = 1.2f,
                ["cheese"] = .5f,
                ["sauce"] = .45f
            };
    }
}
