using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntLifePCL.Poli
{
    public class MilitaryBase : BaseBody
    {
        #region Konstruktor z dziedziczenia
        public MilitaryBase(string Name, float Longitude, float Latitude) : base(Name, Longitude, Latitude)
        {
            WallResistance = 0;
        }

        public MilitaryBase(string Name, float Longitude, float Latitude, int WallResistance) : base(Name, Longitude, Latitude)
        {
            this.WallResistance = WallResistance;
        }
        #endregion




        #region polimorfizmDynamicznyy

        public int WallResistance { get; set; }

        public override void CreateBase(string Name, float Longitude, float Latitude)
        {
            //Debug.WriteLine("MilitaryBase - Name: " + Name);
            //Debug.WriteLine("MilitaryBase - Localization: " + Longitude + " | " + Latitude);


            base.CreateBase(Name, Longitude, Latitude);
            Debug.WriteLine("MilitaryBase - Wall Resistance: 0");
        }

        public virtual void CreateBase(string Name, float Longitude, float Latitude, int WallResistance)
        {
            base.CreateBase(Name, Longitude, Latitude);
            //CreateBase(Name, Longitude, Latitude);
            Debug.WriteLine("MilitaryBase - Wall Resistance: " + WallResistance);
        }

        #endregion
    }

}

