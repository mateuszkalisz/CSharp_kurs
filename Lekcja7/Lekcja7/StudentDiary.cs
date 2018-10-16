using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja7
{
    class StudentDiary
    {
        //stan(zmienne - pola)
        List<float> ratings = new List<float>(); //utworzenie listy ocen zmiennoprzecinkowych typu generycznego

        //zachowania

        /// <summary>
        /// dodaje ocene do listy ocen
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        /// <summary>
        /// oblicza srednia z ocen w dzienniczku
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {

            float sum = 0;
            float avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();

            return avg;
        }

        /// <summary>
        /// oblicza max liczbe z dzienniczka
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        /// <summary>
        /// oblicza min liczbe z dzienniczka
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }

    }
}