using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    class Program
    {
        static void Main()
        {
            decimal deliveryFee = 0.10m;
            var pizza = new PepperoniPizza(deliveryFee);

            Console.WriteLine("Pizza Price: " + (pizza.Price + pizza.ExtraPrice));
            Console.ReadKey();
        }
    }
}
