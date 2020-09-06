using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Typy
{
    public class Diary
    {
        public Diary()
        {
            Ratings = new List<float>();                  
        }
        //Stan -> zmienne (pola) (WŁAŚCIWOŚCI) -> trzeba zaincjować zmienną - > w tym wypadku new 
        public List<float> Ratings = new List<float>();
        // do każdego nowego dzienniczka dodamy jego nazwę
        public string Name;

       
        //Zachowania -> metody 
        public void AddRating(float rating) 
        {
            Ratings.Add(rating);
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
