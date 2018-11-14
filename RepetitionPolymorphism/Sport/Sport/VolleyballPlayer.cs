using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class VolleyballPlayer: SportsMan
    {
        public float Jump;

        public override void CreateSportsMan(string Name, string KindOfSport, int Popularity)
        {
            base.CreateSportsMan(Name, KindOfSport, Popularity);    
        }

        public virtual void CreateSportsMan(string Name, string KindOfSport, int Popularity, float Jump)
        {
            base.CreateSportsMan(Name, KindOfSport, Popularity);
            Console.WriteLine("Jump: " + Jump);
        }

    }
}
