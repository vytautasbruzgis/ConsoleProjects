using SampleConsole;
using System;

namespace SampleConsoleProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            var car2 = new Car();

            car1.StartEngine();
            Car.Static_StartEngine();

            var randomnumber = "5";
            PrintInfo(randomnumber);
        }

        public static void PrintInfo(string info)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


