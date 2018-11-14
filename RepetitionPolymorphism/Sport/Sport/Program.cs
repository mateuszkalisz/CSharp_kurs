using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    class Program
    {
        static void Main(string[] args)
        {
            //SportsMan men1 = new SportsMan();
            FootballPlayer men2 = new FootballPlayer();
            FootballPlayer men3 = new FootballPlayer();
            VolleyballPlayer men4 = new VolleyballPlayer();

            //men1.CreateSportsMan("Beginner player", "Table tennis", 1);
            men2.CreateSportsMan("Roberto Carlos", "Football", 8, 10);
            men2.Age(43);
            men3.CreateSportsMan("Ronaldinho", "Football", 10, 7);
            men3.Age(38);
            men4.CreateSportsMan("Bartek Kurek", "Volleyball", 10, 1.5f);
            men4.Age(29);


            Console.ReadKey();

        }
    }
}
