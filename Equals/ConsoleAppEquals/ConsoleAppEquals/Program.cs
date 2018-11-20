using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = "jaka jest roznica pomiedzy equals i ==";
            object a1 = new string("jaka jest roznica pomiedzy equals i ==".ToCharArray());

            Console.WriteLine(a == a1);  // porownuje referencje obiektu
            Console.WriteLine(a.Equals(a1)); // porownuje wartosci

            Console.WriteLine("-----------------------");

            string b = "blabla";
            string c = "blabla";

            Console.WriteLine(b==c); // tylko w stringu porownuje wartosci, w pozostalych referencje
            Console.WriteLine(b.Equals(c)); // zawsze porownuje wartosci

            Console.ReadKey();


        }
    }
}
