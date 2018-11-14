using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class SportsMan
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

    }
}
