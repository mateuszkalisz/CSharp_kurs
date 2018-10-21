using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj wiek");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(" pętla for: ");

            for (int i = 0; i < age; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" pętla while: ");

            while (age>0)
            {
                age--;
                Console.WriteLine(age);
            }

            Console.WriteLine(" pętla do while: ");

            do
            {
                age--;
                Console.WriteLine(age);
            } while (age > 0);

            Console.WriteLine(" pętla foreach: ");

            int[] tablica = {10, 20, 30, 40, 50, 99};

            foreach (var element in tablica)
            {
                Console.WriteLine(element);
            }

            

            Console.ReadKey();

        }
    }
}
