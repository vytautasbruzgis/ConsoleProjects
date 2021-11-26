using System;

namespace _20211124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Vytautas";
            var lastname = "Bruzgis";
            var birthyear = "1984";
            var thisyear = "2021";

            try
            {
                int age = Convert.ToInt32(thisyear) - Convert.ToInt32(birthyear);
                Console.WriteLine("Aš esu " + name + " " + lastname +". Man yra " + age.ToString() + "metai(ų)");
            }
            catch
            {
                Console.WriteLine("Something went wrong!");
            }

            var names = new string[] { "Vaidas", "Arūnas", "Giedrius", "Ignas", "Auksė", "Donatas", "Edgaras" };
            
            foreach(string n in names)
            {
                Console.WriteLine(n);
            }

            /*  */

            Console.WriteLine("Trečias");

            Random rnd = new Random();
            
            var numbers = new int[10];
            for(int i = 0; i < 5; i++)
            {
                numbers[i] = rnd.Next(5, 10);
            }
            foreach (int num in numbers) {
                Console.WriteLine(num.ToString());
            }
            for (int i = 5; i < 10; i++)
            {
                numbers[i] = rnd.Next(5, 10);
            }
            foreach (int num in numbers)
            {
                Console.WriteLine(num.ToString());
            }

            Console.WriteLine("Ketvirtas");

            int[,] matrix = new int[10, 10];

            for (int i = 0;i < 10; i++)
            {
                for (int j = 0;j < 10; j++)
                {
                    matrix[i, j] = i * j;
                }
            }

            Console.WriteLine("  1  2  3  4  5  6  7  8  9 ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i.ToString() + " ");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matrix[i, j].ToString() + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Penktas");

            

            try
            {
                int a, b, c;
                Console.Write("Įveskite kraštinę a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Įveskite kraštinę b:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Įveskite kraštinę c:");
                c = Convert.ToInt32(Console.ReadLine());
                var answer = canDoTriangle(a, b, c) == true ? "Taip" : "Ne";
                Console.WriteLine(answer);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Šeštas");
            var rand = new Random();

            int kiekis = rand.Next(1001, 3000);
            Console.WriteLine(kiekis.ToString() + " žvakių kainuos " + calculatePrice(kiekis).ToString());

            Console.WriteLine("Septintas");
            int hh = rand.Next(0, 23);
            int mm = rand.Next(0, 59);
            int ss = rand.Next(0, 59);
            int randomSeconds = rand.Next(0, 300);

            DateTime currentTime = new DateTime(2021, 11, 24, hh, mm, ss);
            Console.WriteLine(currentTime.ToString());
            currentTime = currentTime.AddSeconds(randomSeconds);
            Console.WriteLine(currentTime.ToString());

        }
        public static bool canDoTriangle(int a = 1, int b = 1, int c = 1)
        {

            return a + b > c ? (b + c > a ? ( a + c > b ? true : false) : false) : false;
        }
        public static double calculatePrice(int count)
        {
            Console.WriteLine("Kiekis: "+ count.ToString());
            double price = 1;
            int discount = count * price < 1000 ? 0 : count * price > 2000 ? 4 : 3;
            Console.WriteLine("Nuolaidos proc: " + discount.ToString());
            Console.WriteLine(((double)((double)(100 - discount) / (double)100)) +" discountas");
            double result = price * count * ( (double) ( (100 - discount) / (double)100) );

            return Math.Round(result, 2);
        }
    }   
        
}
