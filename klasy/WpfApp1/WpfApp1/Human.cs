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

        public string Password { get; set; }
        public string Login { get; set; }

        public int Age { get; private set; }
        
        //przeciazenie konstruktora
        public Human(string name, Gender gender, DateTime birthDate)
        {
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Age = CalcAge(2);
            Password = GeneratePassword();
            Login = "NO LOGIN HERE";
            Password = "";
            
            //Age = DateTime.Now.Year - BirthDate.Year;
        }

        public Human(string name, Gender gender, DateTime birthDate, string password, string login)
        {
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Age = CalcAge(2);
            Password = password;
            Login = CheckLogin(login) ? login : "Wrong login";
            //Age = DateTime.Now.Year - BirthDate.Year;
        }



        #region przeciazanie metody obliczania wieku
        public static int CalcAge(DateTime BirthDate)
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public static int CalcAge(int age)
        {
            return DateTime.Now.Year - age;
        }
        #endregion


        #region GenerowanieLosowegoHasla
        private string GeneratePassword()
        {
            return Guid.NewGuid().ToString();
        }
        #endregion

        #region Login
        public bool CheckLogin(string login)
        {
            bool isCorrected = false;
            if (login.Length > 7) isCorrected = true;
            return isCorrected;
        }
        #endregion

    }
}
