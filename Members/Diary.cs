using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Members
{
    class Diary
    {
        public Diary()
        {
            Ratings = new List<float>();                    
        }
        
        List<float> Ratings = new List<float>();
        public void AddRating(float rating) 
        {
            if (rating >= 0 && rating <= 10)
            {
                Ratings.Add(rating);
            }
        }

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

        
    }
}
