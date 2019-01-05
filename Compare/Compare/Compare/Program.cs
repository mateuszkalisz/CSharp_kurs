using System;
using System.Collections.Generic;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("fiat", 1999);
            Auto auto2 = new Auto("audi", 2004);
            Auto auto3 = new Auto("vw", 2009);
            Auto auto4 = new Auto("ford", 1992);
            Auto auto5 = new Auto("citroen", 1991);

            List<Auto> list = new List<Auto>();
            list.Add(auto1);
            list.Add(auto2);
            list.Add(auto3);
            list.Add(auto4);
            list.Add(auto5);

            list.Sort(new AutoComparer());

            foreach (var item in list)
            {
                Console.WriteLine(item.Model + " = " + item.Year);
            }

            Console.ReadKey();
        }
    }

    class AutoComparer : IComparer<Auto>
    {
        public int Compare(Auto x, Auto y)
        {
            if (x.Year < y.Year)
                return 1;
            else if (x.Year == y.Year)
                return 0;
            else
                return -1;
        }
    }

    class Auto : IComparable
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Auto(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public int CompareTo(object obj)
        {
            var arg = (Auto)obj;

            if (Year < arg.Year)
                return 1;
            else if (Year == arg.Year)
                return 0;
            else
                return -1;
        }
    }
}
