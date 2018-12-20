using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Polimorfizm
{
    public class Base
    {
        //fields
        public virtual string Name { get; set; }
        public virtual float Longitude { get; set; }
        public virtual float Latitude { get; set; }

        //method

        public virtual void CreateBase(string Name, float Longitude, float Latitude)
        {
            Console.WriteLine("Basebody+ Set name: " + Name);
            Console.WriteLine("Basebody+ Set Localization: " + Longitude + " : " + Latitude);
        }
    }
}
