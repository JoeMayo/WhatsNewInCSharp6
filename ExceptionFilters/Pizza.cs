using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    public class Pizza
    {
        public DateTime[] CheckDeliveryTimes(string town, string street)
        {
            throw new ArgumentNullException(nameof(town));
        }
    }
}
