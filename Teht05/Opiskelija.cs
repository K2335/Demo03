using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Opiskelija
    {
        // properties
        public string Name { get; set; }
        public int StudentID { get; set; }
        public int Grade { get; set; }

        // constructor
        public Opiskelija()
        {
            Name = "";
            StudentID = 0;
            Grade = 0;
        }


        // methods
        public void PrintData()
        {
            Console.WriteLine("Name of the student: " + Name);
            Console.WriteLine("Student-ID: " + StudentID);
            Console.WriteLine("Grade from the programming course: " + Grade);
        }
    }
}
