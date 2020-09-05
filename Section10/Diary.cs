using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Section10
{
    class Diary
    {
        
        //Stan -> zmienne (pola) -> trzeba zaincjować zmienną - > w tym wypadku new 
        List<float> Ratings = new List<float>();
        
        //Zachowania -> metody 
        public void AddRating(float rating) 
        {
            if (rating <= 0 && rating >=10)
            {
                Ratings.Add(rating);
            }
            
        }

        public float CalculateAverage()
        {
            var sum = (float)0;
            var avg = (float)0;
            
            foreach (var rating in Ratings)
            {
                sum += rating;
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
