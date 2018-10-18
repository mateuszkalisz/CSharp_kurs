using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
        
        static void GiveName(StudentDiary diary)
        {
            diary.Name = "Dzienniczek Mateusza";
        }

       
        static void Main(string[] args)
        {
            StudentDiary diary = new StudentDiary(); // utworzenie nowej instancji klasy 
            diary.AddRating(3);
            diary.AddRating(5);

            StudentDiary diary2 = new StudentDiary(); // utworzenie drugoiego obiektu i przypisanie do drugiej zmiennej
            diary2.AddRating(8);

            StudentDiary diary3 = diary2; // przypisanie do trzeciej zmiennej drugiej zmiennej (czyli beda sie odwolywac do tego samego [drugiego] obiektu
            diary2.AddRating(7.5f);
            //StudentDiary diary; // utworzenie zmiennej (jeszcze nie przypisalismy obiektu!)

            DiaryStatistics stats = diary.ComputeStatistics();

            Console.WriteLine("Średnia ocena: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);

            stats = diary2.ComputeStatistics();

            Console.WriteLine("Średnia ocena: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);

            StudentDiary d1 = new StudentDiary();
            GiveName(d1);
            Console.WriteLine(d1.Name);

        }
    }
}

