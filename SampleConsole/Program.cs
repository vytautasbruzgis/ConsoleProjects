using SampleConsole;
using System;

namespace SampleConsoleProjects
{
    class Program
    {
        public static void Main(string[] args) { 
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

            /* readline */
            try
            {
                var mathOperators = new List<string>() { "+", "-", "*", "/" };

                Console.WriteLine("Įveskite reikšmę x");
                string xString = Console.ReadLine();
                int x = Convert.ToInt32(xString);

                double mathresult = 0;

                string mathOperator;

                do
                {
                    Console.WriteLine("Įveskite matematinį operatorių +, -, * arba /");
                    mathOperator = Console.ReadLine();
                } while (!mathOperators.Contains(mathOperator));


                Console.WriteLine("Įveskite reikšmę y");
                string yString = Console.ReadLine();
                int y = Convert.ToInt32(yString);

                switch (mathOperator)
                {
                    case "+": mathresult = x + y; break;
                    case "-": mathresult = x - y; break;
                    case "*": mathresult = x * y; break;
                    case "/": mathresult = x / y; break;
                }

                Console.WriteLine(Convert.ToString(mathresult));
            } catch (Exception e)
            {
                Console.WriteLine("Klaida: " + e.Message);
            }
            

            //var consoleInput = v;
            //var allNumbers = v.Split(" ");
            //for (int i = 0; i < allNumbers.Length; i++)
            //{
            //    //fgPrintInfo(v ?? "negauta reikšmė");
            //    Console.WriteLine(allNumbers[i] ?? "negauta reikšmė");
            //}



        }

        public static void PrintInfo(string info)
        {
            Console.WriteLine(info);
        }
    }
}


