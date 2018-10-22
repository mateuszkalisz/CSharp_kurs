using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumping
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tablica;
            tablica = new int[5];
            tablica[0]= 3;
            tablica[1] = 5;
            tablica[2] = 6;
            tablica[3] = 7;
            tablica[4] = 8;

            foreach (var item in tablica)
            {
                Console.WriteLine(item);
                if (tablica[3] == 5) break;

            }

            int maxnumbers = 100;

            for (int i = 0; i < maxnumbers; i++)
            {
                if (i < 20) continue;
                Console.WriteLine("Mateusz jest mistrzem x" + i);
            }

            int[] ages = { 10, 20, 30, 40, 50 };

            foreach (int age in ages)
            {
                Console.WriteLine("huehue " + age);
                if (age == 40) return;

            }

            foreach (int age in ages)
            {
                Console.WriteLine(age);
                if (age == 30) goto skip; 
            }

 
            skip:
            Console.WriteLine("blablabla");

            Console.ReadKey();
        }
    }
}
