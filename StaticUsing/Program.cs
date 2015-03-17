using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static StaticUsing.MyInstanceWithStatic;

namespace StaticUsing
{
    class Program
    {
        static void Main()
        {
            string val = MyValue;
            WriteLine("Hello!");
            ReadKey();
        }
    }
}
