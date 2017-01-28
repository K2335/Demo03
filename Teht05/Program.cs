using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija keijo = new Opiskelija();
            keijo.PrintData();
            Console.ReadLine();

            keijo.Name = "Keijo Kalastaja";
            keijo.StudentID = 4580;
            keijo.Grade = 4;
            keijo.PrintData();
            Console.ReadLine();

            Opiskelija erno = new Opiskelija();
            erno.Name = "Erno Palomies";
            erno.StudentID = 6514;
            erno.Grade = 2;
            erno.PrintData();
            Console.ReadLine();           
        }
    }
}
