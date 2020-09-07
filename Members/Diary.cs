using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Members
{
    class Diary
    {
        // konstruktor
        public Diary()
        {
            Ratings = new List<float>();                    
        }

        //stan (zmienne - pola)
        private List<float> Ratings = new List<float>();

        private string _name;// nie ma dostępu do tego pola spoza klasy

        public string Name//- > to jest pole, jak dodamy get, set mamy właściwość
                            // do Name mamy dostęp spoza klasy -> jest public
                            // dlatego, że mamy własne gettery i settery (dodajemy własną logikę) musimy mieć pole prywatne -> _name

        {
            get // get set - > akcesory
            {
                return _name.ToUpper();
            }
            set // używamy value
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChanged(_name, value);
                    }
                    
                    _name = value;
                }
            }
        }

        //Delegat

        public NameChangeDelegate NameChanged;

        // VS skrót -> prop + tab tab, np.:
        // public int MyProperty { get; set; }

        //Zachowania
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
