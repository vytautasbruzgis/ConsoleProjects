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

            /* bandymas padidinti array */
            var arrayOfInts = new[] { 1, 2, 3, 4, 5, 6 };
            arrayOfInts.Append(8);
            try { 
                   PrintInfo(arrayOfInts[6].ToString());  
            }
            catch(Exception e)
            {
                Console.WriteLine("Klaida: " + e.Message);
            }
            
        }

        public static void PrintInfo(string info)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


