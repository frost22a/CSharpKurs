using System;

namespace Members
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            //diary.AddRating(3.5f);
            //diary.AddRating(5.4f); 
            //diary.AddRating(8.4f);

            //DiaryStatistics stats = diary.ComputeStats();

           
            //diary.Name = "";
            //diary.Name = null;
            //Console.WriteLine(diary.Name);
            

            diary.NameChanged += new NameChangeDelegate(NameChange); // "+=" dopisuje metodę do delegata, nie nadpisuje jej
            diary.NameChanged += new NameChangeDelegate(NameChange2);
            diary.NameChanged += new NameChangeDelegate(NameChange3);
            diary.NameChanged += new NameChangeDelegate(NameChange4);
            diary.Name = "Dzienniczek Marcina";
            diary.Name = "Jacek";


            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.MaxGrade);
            //Console.WriteLine(stats.MinGrade);

            //WriteResult("średnia", stats.AverageGrade);
            //WriteResult("max", stats.MaxGrade);
            //WriteResult("min", stats.MinGrade);

        }

        private static void NameChange(string ExistingName, string NewName)
        {
            Console.WriteLine($"Zmiana nazwy z {ExistingName} na {NewName}");
        }
         private static void NameChange2(string ExistingName, string NewName)
        {
            Console.WriteLine("==========================");
        }
        private static void NameChange3(string ExistingName, string NewName)
        {
            Console.WriteLine("*************    ****************");
        }
        private static void NameChange4(string ExistingName, string NewName)
        {
            Console.WriteLine("ELO!");
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

