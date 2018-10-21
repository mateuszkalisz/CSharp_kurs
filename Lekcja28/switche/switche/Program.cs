using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imie: ");
            string name = Console.ReadLine();

            switch(name)
            {
                case "Mateusz":
                    Method1();
                    break;

                case "Maja":
                    Method2();
                    break;
                default:
                    Method3();
                    break;
            }

            Console.ReadKey();

        }

        static void Method1()
        {
            Console.WriteLine("Witaj mistrzu!");
        }

        static void Method2()
        {
            Console.WriteLine("Witaj szefunciu!");
        }

        static void Method3()
        {
            Console.WriteLine("Witaj nieznajomy!");
        }

    }
}
