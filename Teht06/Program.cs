using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            Kahvinkeitin braun = new Kahvinkeitin();
            braun.PrintData();
            Console.ReadLine();

            // set value
            braun.Name = "Braun";
            braun.Cups = 3;
            braun.Ready = true;
            braun.Power = true;

            braun.PrintData();
            Console.ReadLine();
        }
    }
}
