using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja7
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDiary diary = new StudentDiary();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            for (; ; )
            {
                Console.WriteLine("podaj ocene z zakresu 1-10: ");

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 11)
                {
                    break;  // wyjscie z pętli for(; ;)
                }


                if(result == true)
                {
                    if(rating >0 && rating <=10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("podales niepoprawna liczbe!");
                    }
                    
                }

                
            }

            float avg = diary.CalculateAverage();
            float maxrating = diary.GiveMaxRating();
            float minrating = diary.GiveMinRating();

            
            Console.WriteLine("Średnia wynosi: " + avg);
            Console.WriteLine("Max ocena: " + maxrating);
            Console.WriteLine("Min ocena: " + minrating);
            Console.ReadKey();

        }
    }
}
