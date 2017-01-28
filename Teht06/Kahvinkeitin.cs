using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Kahvinkeitin
    {
        // properties
        public string Name { get; set; }
        public int Cups { get; set; }
        public bool Ready { get; set; }
        public bool Power { get; set; }

        // constructor
        public Kahvinkeitin()
        {
            Name = "";
            Ready = false;
            Power = false;
    
        }


        // methods
        public void PrintData()
        {
            Console.WriteLine("Brand name of the coffee machine: " + Name);
            Console.WriteLine("Coffee machine is on: " + Power);
            Console.WriteLine("How many cups would you like?: " + Cups);
            Console.WriteLine("Coffee is ready: " + Ready);
        }
    }
}
