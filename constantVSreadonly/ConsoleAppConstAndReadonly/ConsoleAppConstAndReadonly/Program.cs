using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstAndReadonly
{

    /// <summary>
    /// Constant vs Readonly
    /// </summary>

    class Program
    {
        public const int thisIsConst = 10; // const - jest tworzone w trakcie kompilacji, tego w ogole nie mozemy zmienic nawet w konstruktorze
        public static readonly double thisIsReadonly = 11; // readonly - jest przypisywane w runtime'ie, mozna zmienic w konstruktorze - czyli w trakcie tworzenia danej klasy

        public const string MyKey = "MyKey";
        public static readonly double betterPI = Math.PI;

        static Program()
        {
            thisIsReadonly = 10.11;
            betterPI = Convert.ToDouble(ConfigurationManager.AppSettings[MyKey], CultureInfo.InvariantCulture);
        }

        static void Main(string[] args)
        {
        }
    }
}
