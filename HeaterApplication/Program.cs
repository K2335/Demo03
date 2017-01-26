using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of heater class

            Heater harvia = new Heater();

            // set values
            harvia.IsOn = true;
            harvia.Temperature = 100;
            harvia.Humidity = 70;

            // testing...
            harvia.PrintDetails();
        }
    }
}
