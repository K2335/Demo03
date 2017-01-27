using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Tv
    {
        // properties
        public bool IsOn { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }
        
        // constructor
        public Tv()
        {
            Channel = 1;
        }
            

        // methods
        public void PrintDetails()
        {
            Console.WriteLine("Power: " + IsOn);
            Console.WriteLine("Channel: " + Channel);
            Console.WriteLine("Volume level: " + Volume);
        }
        public void VolumeUp()
        {
            Volume += 5;
        }
        public void VolumeDown()
        {
            Volume -= 5;
        }


    }
}
