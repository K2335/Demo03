using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Pesukone
    {
        // properties
        public bool IsOn { get; set; }
        public int Program { get; set; }
        public bool Sling { get; set; }
        // constructors, ei pakollinen

        // methods
        public void PrintDetails()
        {
            Console.WriteLine("Power: " + IsOn);
            Console.WriteLine("Program: " + Program);
            Console.WriteLine("Sling: " + Sling);
        }

        public void Power(bool set)
        {
            IsOn = false;
            Sling = false;
        }
    }
}
