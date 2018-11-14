using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public abstract class SportsMan
    {
        public virtual string Name { get; set; }
        public virtual string KindOfSport { get; set; }
        public virtual int Popularity { get; set; }

        public virtual void CreateSportsMan(string Name, string KindOfSport, int Popularity)
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Kind of sport: " + KindOfSport);
            Console.WriteLine("Popularity: " + Popularity);
        }

        public abstract void Age(int Age); // jak tworzymy metode abstrakcyjna to i klasa musi byc abstrakcyjna - wtedy kazda klasa ktora dziedziczy z klasy abstrakcyjnej musi uzyc tej metody


    }
}
