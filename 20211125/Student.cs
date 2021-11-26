using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211125
{
    class Student
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}, amžius - {2}", this.Name, this.Lastname, this.Age);
        }

        public static void sayBye()
        {
            Console.WriteLine("Bye bye");
        }
    }
}
