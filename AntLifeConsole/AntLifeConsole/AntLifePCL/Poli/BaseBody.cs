using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntLifePCL.Poli
{
    public class BaseBody
    {
        #region Konstruktory

        public BaseBody()
        {

        }

        public BaseBody(string Name, float Longitude, float Latitude)
        {
            this.Name = Name;
            this.Longitude = Longitude;
            this.Latitude = Latitude;
        }

        #endregion

        #region polimorfizm dynamiczny

        public virtual string Name { get; set; }
        public virtual float Longitude { get; set; } // dlugosc geogr
        public virtual float Latitude { get; set; } // szerokosc geogr

        public virtual void CreateBase(string Name, float Longitude, float Latitude)
        {
            Debug.WriteLine("BaseBody - Name: " + Name);
            Debug.WriteLine("BaseBody - Localization: " + Longitude + " | " + Latitude);
        }

        #endregion



    }
}
