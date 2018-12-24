using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Polimorfizm
{
    class MilitaryBase : Base
    {
        public MilitaryBase(string Name, float Longitude, float Latitude) : base(Name, Longitude, Latitude)
        {
            WallResistance = 0;
        }

        public MilitaryBase(string Name, float Longitude, float Latitude, int WallResistance) : base(Name, Longitude, Latitude)
        {
            this.WallResistance = WallResistance;
        }

        //fields

        public int WallResistance { get; set; }

        public override void CreateBase(string Name, float Longitude, float Latitude)
        {
            base.CreateBase(Name, Longitude, Latitude);
            //Console.WriteLine("MilitaryBase + Set name: " + Name);
            //Console.WriteLine("MilitaryBase + Set Localization: " + Longitude + " : " + Latitude);
            Console.WriteLine("wall resist: 0");
        }

        //method

        public virtual void CreateBase(string Name, float Longitude, float Latitude, int WallResistance)
        {
            base.CreateBase(Name, Longitude, Latitude);
            //CreateBase(Name, Longitude, Latitude);
            Console.WriteLine("military Wall resistance: " + WallResistance);
        }
    }
}
