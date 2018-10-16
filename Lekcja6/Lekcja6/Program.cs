using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;) //petla powtarzajaca sie w nieskonczonosc
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void Age()
        {
            Console.Write("wpisz ile masz lat: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            //int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Masz 18 lat, może piwko?");
            }

            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Uzytkowniku wprowadziles niepoprawny wiek!");
            }

            else
            {
                Console.WriteLine("Nie masz 18 lat, chcesz mleko?");
            }
        }

        private static void Greeting()
        {
            Console.Write("Wpisz swoje imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
    }
}
