using System;

namespace Typy
{
    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy NOWY obiekt dzienniczek - instancję klasy Diary - > słowo kluczowe NEW
            // instancję tworzy konstruktor (w tym wypadku "domyślny" -> tworzymy tablicę)

            //Diary diary = new Diary();

            // dodajemy pierwszą ocenę -> zmienna PLUS "." -> korzystamy ze zdefiniowanych metod

            //diary.AddRating(5);
            //diary.AddRating(8.5f); //f za liczbą -> typ float 
            //diary.AddRating(4.7f);

            //Diary diary2 = new Diary();
            //Diary diary3 = new Diary();
            //Diary diary4 = new Diary();
            //Diary diary5 = new Diary();
            //Diary diary6 = new Diary();

            //DiaryStatistics ststs = diary.ComputeStats();

            Diary d1 = new Diary();
            Diary d2 = d1;

            d1.Name = "Dzienniczek Marty";

            d1 = new Diary();

            d1.Name = "Dzienniczek Marcina";

            Console.WriteLine("d2 name:" + d2.Name);
            Console.WriteLine("d1 name: " + d1.Name);

            int x1 = 4;
            int x2 = x1;

            x1 = 100;
            Console.WriteLine(x2);
           
            
        }
    }
}
