using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new Pizza();

            string menuItem = $"Name: {pizza.Name}, Price: {pizza.Price}";

            Console.WriteLine(menuItem);
            Console.WriteLine();

            Console.WriteLine($"Name: {pizza.Name,-15}, Price: {pizza.Price:C}");

            Console.ReadKey();
        }
    }
}
