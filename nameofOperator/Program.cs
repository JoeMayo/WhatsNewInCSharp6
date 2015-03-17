using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameofOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Parameter to Main is named {nameof(args)}");

            var pizza = new Pizza();

            Console.WriteLine($"Price is {nameof(pizza.Price)}");

            Console.ReadKey();
        }
    }
}
