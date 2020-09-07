using System;
using System.IO;

namespace Members
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Diary diary = new Diary();


            //try
            //{
            //    Console.WriteLine("Podaj imię:");
            //    diary.Name = Console.ReadLine();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (NullReferenceException) 
            //{

            //    Console.WriteLine("Coś poszło nie tak");
            //}

            //diary.AddRating(3.5f);
            //diary.AddRating(5.4f); 
            //diary.AddRating(8.4f);

            //DiaryStatistics stats = diary.ComputeStats();


            //diary.Name = "";
            //diary.Name = null;
            //Console.WriteLine(diary.Name);


            //diary.NameChanged += new NameChangeDelegate(NameChange); // "+=" dopisuje metodę do delegata, nie nadpisuje jej
            //diary.NameChanged += new NameChangeDelegate(NameChange2);
            //diary.NameChanged += new NameChangeDelegate(NameChange3);
            //diary.NameChanged += new NameChangeDelegate(NameChange4);
            //diary.NameChanged += new NameChangeDelegate(NameChange4);
            //diary.NameChanged += new NameChangeDelegate(NameChange4);
            //diary.NameChanged += new NameChangeDelegate(NameChange4);

            //wersja prostsza:

            //diary.NameChanged += NameChange; // "+=" dodaj subskrybcję w event -= ją anuluje 
            //diary.NameChanged += NameChange2;
            //diary.NameChanged += NameChange3;
            //diary.NameChanged += NameChange4;
            //diary.NameChanged += NameChange4;
            //diary.NameChanged += NameChange4;
            //diary.NameChanged += NameChange4;
            //diary.NameChanged -= NameChange4;
            //diary.NameChanged -= NameChange4;
            //diary.NameChanged -= NameChange4;




            //diary.Name = "Dzienniczek Marcina";
            //diary.Name = "Jacek";


            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.MaxGrade);
            //Console.WriteLine(stats.MinGrade);

            //WriteResult("średnia", stats.AverageGrade);
            //WriteResult("max", stats.MaxGrade);
            //WriteResult("min", stats.MinGrade);

            StreamWriter file = new StreamWriter("plik.txt");
            try
            {
                file.WriteLine("piszemy do pliku tekstowego");
            }
            finally
            {
                file.Close();
            }

                                                                                                    // parametr true - dopisujemy do pilku
            using (StreamWriter file1 = new StreamWriter("plik.txt", true)) //using - plik zostanie zamknięty i zasoby zostaną zwolnione
            {
                file1.WriteLine("piszemy do pliku tekstowego!!!");

            }


        }

        //private static void NameChange(object Sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine($"Zmiana nazwy z {args.ExistingName} na {args.NewName}");
        //}
        // private static void NameChange2(object Sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine("==========================");
        //}
        //private static void NameChange3(object Sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine("*************    ****************");
        //}
        //private static void NameChange4(object Sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine("ELO!");
        //}

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

