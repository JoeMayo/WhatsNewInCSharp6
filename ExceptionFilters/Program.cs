using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new Pizza().CheckDeliveryTimes(null, null);
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "town")
            {
                Console.WriteLine($"{ex.ParamName} is null");
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "street")
            {
                Console.WriteLine($"You need to specify {ex.ParamName}");
            }

            Console.ReadKey();
        }
    }
}
