using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    public class PepperoniPizza : PizzaBase
    {
        public decimal ExtraPrice { get; set; } = 0.25m;

        public PepperoniPizza(decimal extraFees) : base(new List<string> { "pepperoni" })
        {
            ExtraPrice += extraFees;
            Name = "Pepperoni";
        }
    }
}
