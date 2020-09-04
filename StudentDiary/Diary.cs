using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDiary
{
    class Diary
    {
        //Stan -> zmienne (pola) (WŁAŚCIWOŚCI) -> trzeba zaincjować zmienną - > w tym wypadku new 
        List<float> Ratings = new List<float>();
        
        //Zachowania -> metody 
        public void AddRating(float rating) 
        {
            Ratings.Add(rating);
        }

        //public float CalculateAverage()
        //{
        //    var sum = (float)0;
        //    var avg = (float)0;
            
        //    foreach (var rating in Ratings)
        //    {
        //        sum += rating;
        //    }

        //    avg = sum / Ratings.Count();
        //    return avg;
        //}

        public DiaryStatistics ComputeStats() 
        {
            // chcemy, żeby metoda zwracałą obiekt DiaryStatistics
            DiaryStatistics stats = new DiaryStatistics();
            
            var sum = 0f;
            foreach (var rating in Ratings)
            {
                sum += rating;
            }
            stats.AverageGrade = sum / Ratings.Count();
            stats.MaxGrade = Ratings.Max();
            stats.MinGrade = Ratings.Min();

            return stats;
        }

        //public float GiveMaxRating() 
        //{
        //    return Ratings.Max();
        //}

        //public float GiveMinRating()
        //{
        //    return Ratings.Min();
        //}

    }
}
