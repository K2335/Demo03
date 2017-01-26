using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Heater
    {
        // properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public double Humidity { get; set; }
        // constructors, ei pakollinen
       
        // methods
        public void PrintDetails()
        {
            Console.WriteLine("Power: " + IsOn);
            Console.WriteLine("Temperature: " + Temperature);
            Console.WriteLine("Humidity: " + Humidity);
        }

        public void Power(bool set)
        {
            IsOn = true;
        }

       
    }
}
