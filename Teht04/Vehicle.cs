using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Vehicle
    {
        // properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        // constructor
        public Vehicle()
        {
            Name = "Car";
            Speed = 0;
            Tyres = 0;
        }


        // methods
        public void PrintData()
        {
            Console.WriteLine("Name of the car: " + Name);
            Console.WriteLine("Speed of the car: " + Speed);
            Console.WriteLine("Cars tyre count: " + Tyres);
        }
        public override string ToString()
        {
            return "Name: "+ Name + "\nSpeed: " + Speed + "\nTyres: " + Tyres;
        }



    }
}
