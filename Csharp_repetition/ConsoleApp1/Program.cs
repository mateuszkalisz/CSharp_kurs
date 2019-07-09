using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Greetings();

            for(int i=0; i<3; i++)
            {
                Console.WriteLine("wprowadz imie");
                string name = Console.ReadLine();
                Console.WriteLine("Twoje imie to " + name);


                Console.WriteLine("Podaj wiek");
                int age = int.Parse(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("Brawo jestes pelnoletni");
                }

                else
                {
                    Console.WriteLine("Mozemy ci zaoferowac mleko");
                }
                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadKey();
        }

        private static void Greetings()
        {
            Console.WriteLine("witaj, podaj swoje dane:");
        }
    }
}
