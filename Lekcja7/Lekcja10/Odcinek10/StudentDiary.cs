using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class StudentDiary
    {
        public StudentDiary()     // konstruktor (ctor+tab) inicjuje wartosci pol zerami jesli nie ma podanych argumentow, nie zwraca zadnych wartosci, tworzy nowy obiekt, ma taka sama nazwe jak nazwa klasy
        {
            ratings = new List<float>();
        }

        //stan(zmienne - pola)
        List<float> ratings;
        // jak inicjalizujemy w konstruktorze to nie trzeba inicjalizowac -> List<float> ratings = new List<float>(); //utworzenie listy ocen zmiennoprzecinkowych typu generycznego

        //zachowania (metody)

        /// <summary>
        /// dodaje ocene do listy ocen
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public static float maksymalna = 10f;
        public static float minimalna = 0f;


        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            /// <summary>
            /// oblicza srednia z ocen w dzienniczku
            /// </summary>
            /// <returns></returns>
                float sum = 0f;
                stats.AverageGrade = 0f;
                foreach (var rating in ratings)
                {
                    sum += rating;
                }
                stats.AverageGrade = sum / ratings.Count();
                stats.MaxGrade = ratings.Max();
                stats.MinGrade = ratings.Min();
                return stats;
        }

        public string Name;

        //public float CalculateAverage()
        //{

        //    float sum = 0;
        //    float avg = 0;
        //    foreach (var rating in ratings)
        //    {
        //        sum += rating;
        //    }
        //    avg = sum / ratings.Count();

        //    return avg;
        //}

        //public float GiveMaxRating()
        //{
        //    return ratings.Max();
        //}

        //public float GiveMinRating()
        //{
        //    return ratings.Min();
        //}

    }
}