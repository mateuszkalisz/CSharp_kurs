using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    class FootballPlayer : SportsMan
    {
        public int ShootPower { get; set; }

        public override void CreateSportsMan(string Name, string KindOfSport, int Popularity)
        {
            base.CreateSportsMan(Name, KindOfSport, Popularity);    
        }

        public virtual void CreateSportsMan(string Name, string KindOfSport, int Popularity, int ShootPower)
        {
            base.CreateSportsMan(Name, KindOfSport, Popularity);
            Console.WriteLine("Shoot Power: " + ShootPower);
        }

        public override void Age(int Age)
        {
            Console.WriteLine("Age: " + Age);
        }

    }
}
