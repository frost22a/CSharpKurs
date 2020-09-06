using System;

namespace Members
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            diary.AddRating(3.5f);
            diary.AddRating(5.4f); 
            diary.AddRating(8.5f);

            DiaryStatistics stats = diary.ComputeStats();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.MaxGrade);
            Console.WriteLine(stats.MinGrade);
                      
             
        }

        
    }
}

