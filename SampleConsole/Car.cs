using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole
{
    public class Car
    {
        public void StartEngine()
        {
            Console.WriteLine("Start the engine .... ");
        }

        public static void Static_StartEngine()
        {
            Console.WriteLine("Start the engine in static .... ");
        }
    }
}
