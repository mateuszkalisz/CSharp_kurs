using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mz.cz3
{
    class Auto
    {

     int age;
     string name;
     float engine;

        public Auto(int age, string name, float engine)
        {
            this.age = age;
            this.name = name;
            this.engine = engine;
        }

        public Auto()
        {
            age = 5;
            name = "audi";
        }
    }
}
