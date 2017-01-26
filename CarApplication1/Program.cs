using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car instance
            Car car = new Car();
            car.Model = "Seat Ibiza";
            car.Color = "Yellow";
            car.Engine = 1.0;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 2;
            Car.SomeProperty = 100;
            // display car data
            car.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            car.Accelerate();
            car.Brake(2);
            // display car data again, notice changed speed value!
            car.PrintData();            
            Console.ReadLine();

            // create a new instance from Car class
            Car nascar = new CarApplication1.Car("Speedstrep");
            nascar.PrintData();
            nascar.Color = "Black";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = true;
            nascar.PrintData();


        }
    }
}
