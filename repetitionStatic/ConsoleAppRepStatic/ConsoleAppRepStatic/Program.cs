using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRepStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StaticMethods.PI);
            Console.WriteLine(StaticMethods.EulerValue);
            Console.WriteLine(StaticMethods.GoldValue);

            Console.WriteLine("Podaj promień koła: ");

            int r = int.Parse(Console.ReadLine());

            double result = StaticMethods.CircleArea(r);

            Console.WriteLine("Pole kola wynosi: " + result);
            



            Console.ReadKey();
        }
    }

    static class StaticMethods
    {
        public static double PI = 3.14;
        public static double EulerValue = 0.577;
        public static double GoldValue = 1.61803;

        public static double CircleArea(int R)
        {
            return PI * R * R;
        }
    }


}
