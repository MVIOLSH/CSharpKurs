using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        //Stan(Zmienne - pola)
        List<float> ratings;


        //Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }


        //Obliczanie 
        public float CalculateAverage()
        {
            float sum = 0, avg = 0;
                       
            foreach (var rating in ratings)
            {
                sum += rating;

            }

            avg = sum / ratings.Count();

            return avg;
        }


        //Zwracanie najwyższej wartości
        public float GivemaxRating()
        {
            return ratings.Max();
        }


        //Zwracanie najniższej wartości
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
