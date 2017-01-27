using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv sony = new Tv();
            sony.PrintDetails();
            Console.ReadLine();

            // set values
            sony.IsOn = true;
            sony.Channel = 3;
            sony.VolumeUp();

            // testing...
            sony.PrintDetails();
            Console.WriteLine();

            sony.VolumeDown();
            sony.PrintDetails();
            Console.WriteLine();
        }
    }
}
