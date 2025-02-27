﻿using System;
using System.Dynamic;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy NOWY obiekt dzienniczek - instancję klasy Diary - > słowo kluczowe NEW
            // instancję tworzy konstruktor (w tym wypadku "domyślny" -> tworzymy tablicę)

            Diary diary = new Diary();

            // dodajemy pierwszą ocenę -> zmienna PLUS "." -> korzystamy ze zdefiniowanych metod

            diary.AddRating(5);
            diary.AddRating(8.5f); //f za liczbą -> typ float 
            diary.AddRating(4.7f);

            DiaryStatistics stats = diary.ComputeStats();

            Console.WriteLine("średnia wartość " + stats.AverageGrade);
            Console.WriteLine("max wartość " + stats.MaxGrade);
            Console.WriteLine("min wartość " + stats.MinGrade);

            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();
            Diary diary6 = new Diary();

            Console.WriteLine(Diary.Counter);
            Console.WriteLine(diary3.Counter2);
            Console.WriteLine(diary6.Counter2);



            //var avg = diary.CalculateAverage();
            //var max = diary.GiveMaxRating();
            //var min = diary.GiveMinRating();

            //for ( ; ; ) // pętla nieskończona
            //{
            //    Console.Write("Podaj ocenę z zakresu 1 - 10 (aby zakończyć wpisz 11): ");
            //    float rating; 
            //    bool isFloat = float.TryParse(Console.ReadLine(), out rating);

            //    if (rating == 11)
            //    {
            //        break;
            //    }

            //    if (isFloat)
            //    {
            //        if (rating > 0 && rating <= 10)
            //        {
            //            diary.AddRating(rating);
            //        }
            //        else 
            //        {
            //            Console.WriteLine("Niepoprawna ocena, wpisz ponownie (z zakresu 1 -10)");
            //        }
            //    }

            //}

            //Console.WriteLine("Średnia Twoich ocen to " + diary.CalculateAverage());
            //Console.WriteLine("Najwyższa ocena to " + diary.GiveMaxRating());
            //Console.WriteLine("Najniższa Twoich ocen to " + diary.GiveMinRating());
            //Console.ReadKey();

        }
    }
}
