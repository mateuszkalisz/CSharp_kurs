using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionSetGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();

            Console.WriteLine("Podaj wiek: ");

            human1.Wiek = int.Parse(Console.ReadLine());

            Console.WriteLine("Masz " + human1.Wiek + " lat");

            Animal animal1 = new Animal();

            Console.WriteLine("Podaj nazwe zwierzaka: ");

            animal1.Name = Console.ReadLine();

            Console.WriteLine("Imie zwierzaka to: " + animal1.Name);

            WithoutSetGet without = new WithoutSetGet();

            Console.WriteLine("Podaj lvl: ");

            without.SetLevel(int.Parse(Console.ReadLine()));

            Console.WriteLine(without.GetLevel());

            Console.ReadKey();
        }

    }
}
