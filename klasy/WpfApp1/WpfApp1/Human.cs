using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Helps;
using static WpfApp1.Helps.EnumHelper;

namespace WpfApp1
{
    class Human
    {
        public string Name { get; set; }
        
        public Gender Gender { get; set; }

        public DateTime BirthDate { get; set; }
        public string Job;

        public int Age { get; private set; }

        public Human(string name, Gender gender, DateTime birthDate)
        {
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Age = DateTime.Now.Year - BirthDate.Year;
        }


        

    }
}
