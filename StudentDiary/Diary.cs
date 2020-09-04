using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDiary
{
    class Diary
    {
        //Stan -> zmienne (pola)
        public List<float> Ratings { get; set; }



        //Zachowania -> metody 
        public void AddRating(float rating) 
        {
            Ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            var sum = (float)0;
            var avg = (float)0;
            
            foreach (var rating in Ratings)
            {
                sum = +rating;
            }

            avg = sum / Ratings.Count();
            return avg;
        }

        public float GiveMaxRating() 
        {
            return Ratings.Max();
        }

        public float GiveMinRating()
        {
            return Ratings.Min();
        }
    }
}
