using System;

namespace Section10
{
    class Program
    {
        static void Main(string[] args)
        {
            // towrzymy zmienną diary typu Diary: 
            // Diary diary; 
            // jej wartość to w tej chwili null -> zmienna jest jakby wskaźnikiem do obiektu
            // teraz zainicjujemy obiekt:
            Diary diary = new Diary();
            // zainicjowaliśmy obiekt klasy Diary - mamy utworzoną nową instancję klasy Diary
            diary.AddRating(3);
            diary.AddRating(5);

            Diary diary2 = diary;
            diary2.AddRating(8);

            Diary diary3 = diary2;
            diary3.AddRating(9);

        }
    }
}
