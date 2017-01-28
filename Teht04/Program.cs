using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();
            car.PrintData();
            Console.ReadLine();


            car.Name = "Seat Ibiza";
            car.Speed = 80;
            car.Tyres = 4;
            car.PrintData();
            Console.ReadLine();
            Console.Write(car.ToString());

        }
    }
}
