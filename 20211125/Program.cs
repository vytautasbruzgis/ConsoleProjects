using System;
using System.Collections.Generic;
using System.Linq;

namespace _20211125
{
    internal class Program
    {
        public static string Lastname { get; private set; }

        static void Main(string[] args)
        {
            ///* pamoka */
            //Console.WriteLine("Hello World!");
            //List<string> names = new List<string>();

            //names.Add("Vytautas");
            //Console.WriteLine(names.Count.ToString());

            //names.AddRange(new List<string>{"Anelė", "Dominyka", "Dorotėja"});
            //Console.WriteLine(names.Count.ToString());

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //names.ForEach(x => Console.WriteLine(x));

            //names.Remove("Anelė");

            //names.ForEach(x => Console.WriteLine(x));

            ///* užduotys */
            //Console.WriteLine("Pirmas");
            Random rnd = new Random();
            //List<int> skaiciai = new List<int>();
            //for(int i = 0; i < 30; i++)
            //{
            //    skaiciai.Add(rnd.Next(5,25));
            //}
            //skaiciai.ForEach(x => Console.WriteLine(x));

            //Console.WriteLine("Užduotis 2.1");
            //var tik10 =  skaiciai.FindAll(x => x.CompareTo(10).Equals(1));
            //Console.WriteLine("Skaiciai didesni už 10");
            //tik10.ForEach(x => Console.WriteLine(x));

            //Console.WriteLine("Užduotis 2.2");
            //int max = skaiciai.Max();
            //Console.WriteLine("Didžiausia reikšmė: " + max);
            //for (int i = 0; i < skaiciai.Count; i++)
            //{
            //    if (skaiciai[i].Equals(max))
            //    {
            //        Console.WriteLine("Indeksas: " + i);
            //    }
            //}
            //Console.WriteLine("Užduotis 2.3");
            //Console.Write("Lyginių indeksų reikšmių suma: ");
            //int sum = 0;
            //for (int i = 0; i < skaiciai.Count; i+=2)
            //{
            //    sum += skaiciai[i];
            //}
            //Console.WriteLine(sum);

            //Console.WriteLine("Užduotis 2.4");
            //List<int> naujiskaiciai = new List<int>();
            //for (int i = 0; i < skaiciai.Count; i++)
            //{
            //    naujiskaiciai.Add(skaiciai[i]-i);
            //}
            //naujiskaiciai.ForEach(x => Console.WriteLine(x));

            //Console.WriteLine("Užduotis 2.5");
            //List<int> poriniaiIndeksai = new List<int>();
            //List<int> neporiniaiIndeksai = new List<int>();
            //for (int i = 0; i < skaiciai.Count; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        poriniaiIndeksai.Add(skaiciai[i]);
            //    } else
            //    {
            //        neporiniaiIndeksai.Add(skaiciai[i]);
            //    }
            //}
            //Console.WriteLine("Poriniu indeksu reiksmes:");
            //poriniaiIndeksai.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine("Neporiniu indeksu reiksmes:");
            //neporiniaiIndeksai.ForEach(x => Console.WriteLine(x));

            //Console.WriteLine("Užduotis 2.6");
            //for (int i = 0; i < skaiciai.Count; i+=2)
            //{
            //    //skaiciai[i] = skaiciai[i] > 15 ? 0 : skaiciai[i];
            //    if (skaiciai[i] > 15)
            //    {
            //        Console.WriteLine("Keiciu reiksme: " + skaiciai[i]);
            //        skaiciai[i] = 0;
            //    }
            //}
            //skaiciai.ForEach(x => Console.WriteLine(x));

            //Console.WriteLine("Užduotis 2.7");

            //skaiciai.ForEach(x => Console.WriteLine(x));

            //for (int i = 0; i < skaiciai.Count; i++)
            //{
            //    //skaiciai[i] = skaiciai[i] > 15 ? 0 : skaiciai[i];
            //    if (skaiciai[i] > 10)
            //    {
            //        Console.WriteLine("Pirmas skaciaus >10 indeksas: " + i);
            //        break;
            //    }
            //}

            //Console.WriteLine("Užduotis 3");
            //List<char> list = new List<char>();

            //for (int i = 0; i < 200; i++){
            //    list.Add((char)rnd.Next('A', 'D'));
            //}

            //int a = 0, b = 0, c = 0, d = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    switch (list[i])
            //    {
            //        case 'A': a += 1; break;
            //        case 'B': b += 1; break;
            //        case 'C': c += 1; break;
            //        case 'D': d += 1; break;
            //    }
            //}

            //Console.WriteLine("A: " + a + ", B: " + b + ", C: " + c + ", D: " + d);

            //Student student = new Student();

            //student.Name = "Vytautas";
            //student.Lastname = "Bruzgis";
            //student.Age = 37;

            //Console.WriteLine(student.ToString());
            //sayHi();
            //Student.sayBye();

            Console.WriteLine("Užduotis 5");
            
            List<char> list1 = new List<char>();
            List<char> list2 = new List<char>();
            List<char> list3 = new List<char>();

            List<string> list4 = new List<string>();
            List<string> uniqueList = new List<string>();
            List<string> differentValuesList = new List<string>();

            for (int i = 0; i < 20; i++)
            {
                list1.Add((char)rnd.Next('A', 'D'));
                list2.Add((char)rnd.Next('A', 'D'));
                list3.Add((char)rnd.Next('A', 'D'));
            }

            for (int i = 0;i < list1.Count; i++)
            {
                list4.Add(list1[i].ToString() + list2[i].ToString() + list3[i].ToString());
            }

            //list4.ForEach(x => {
            //    if (!differentValuesList.Contains(x)) { differentValuesList.Add(x); } 
            //});

            differentValuesList = list4.Distinct().ToList();
            Console.WriteLine("Skirtingų reikšmių: " + differentValuesList.Count);

            differentValuesList.ForEach(x => { 
                Console.Write("Different value:" + x);
                list4.FindAll(y => y == x).Count == 1 ? Console.WriteLine(", reikšmė unikali") : Console.WriteLine(", reikšmė ne unikali");
            });
            
        }

        public static void sayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
