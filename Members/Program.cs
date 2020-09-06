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
            diary.AddRating(8.4f);

            DiaryStatistics stats = diary.ComputeStats();

            diary.Name = "Dzienniczek MArcina";
            diary.Name = "";
            diary.Name = null;
            Console.WriteLine(diary.Name);
            
            
            
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.MaxGrade);
            //Console.WriteLine(stats.MinGrade);

            //WriteResult("średnia", stats.AverageGrade);
            //WriteResult("max", stats.MaxGrade);
            //WriteResult("min", stats.MinGrade);
            
        }

        //static void WriteResult(string description, float result) 
        //{
        //    Console.WriteLine(description + ": " + result);
        //}
        //static void WriteResult(string description, int result) 
        //{
        //    Console.WriteLine(description + ": " + result);
        //}
        //static void WriteResult(string description, long result) 
        //{
        //    Console.WriteLine(description + ": " + result);
        //}
        //static void WriteResult(string description, long result, long test) 
        //{
        //    Console.WriteLine(description + ": " + result);
        //}
        
    }
}

