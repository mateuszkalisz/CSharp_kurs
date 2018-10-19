using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberStudents = 5; // utworzenie zmiennej i przypisanie do niej 5, żeby w późniejszym etapie utworzyc tablice 5 elementowa
            int[] scores = new int[numberStudents]; // utworzenie zmiennej i przypisanie/utworzenie dla niej tablicy o liczbie elementów takiej jaka zadeklarowana zostala w numberstudents (czyli 5) 

            scores[0] = 1;
            scores[1] = 2;
            scores[2] = 15;
            scores[3] = 3;
            scores[4] = 14;

            scores[0] = int.Parse(Console.ReadLine());
            scores[1] = int.Parse(Console.ReadLine());
            scores[2] = int.Parse(Console.ReadLine());
            scores[3] = int.Parse(Console.ReadLine());
            scores[4] = int.Parse(Console.ReadLine());


            int totalScore = 0;

            foreach (var score in scores)
            {
                totalScore += score;
            }

            double averageScore = totalScore / scores.Length;

            Console.WriteLine("Suma wszystkich elementow tablicy: " + totalScore);
            Console.WriteLine("Srednia wszystkich elementow tablicy: " + averageScore);
            Console.ReadKey();


            //int[] blabla = new int[5]; //utworzenie zmiennej blabla i przypisanie/utworzenie dla niej tablicy 5 elementowej




        }
    }
}
