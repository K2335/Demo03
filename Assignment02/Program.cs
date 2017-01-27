using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of heater class
            Pesukone keijo = new Pesukone();
            keijo.PrintDetails();
            Console.ReadLine();

            // set values
            keijo.IsOn = true;
            keijo.Program = 3;
            keijo.Sling = true;

            // testing...
            keijo.PrintDetails();
            Console.WriteLine();
        }
    }
}
