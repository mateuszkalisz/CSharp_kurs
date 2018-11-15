using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGenericsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Compare<string> compString = new Compare<string>();
            Console.WriteLine("Czy a i b sa takie same (liczby napis): " + compString.CompareAnyTypes("mars", "kwas"));

            Compare<int> compInt = new Compare<int>();
            Console.WriteLine("Czy a i b sa takie same (liczby calkowite): "  +compInt.CompareAnyTypes(11,11));

            Console.ReadKey();

        }
    }

    class Compare<AnyType> //moge wpisac cokolwiek zamiast anytype - dowolny zapis, to jest koncept, ogolny typ ktory moze dowolny obiekt zamienic np na int, string, float itd..
    {
        public bool CompareAnyTypes(AnyType a, AnyType b)
        {
            if (a.Equals(b))
                return true;
            else
                return false;
        }
    }
}
