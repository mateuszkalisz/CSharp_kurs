using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
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
        }
    }
}
