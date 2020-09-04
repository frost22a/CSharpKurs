using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Person
    {
        // właściowości:
        int Id;
        string FirstName;
        string LastName;
        string Adrress;
        int Age;
        string Gender;

        public Person() // konstruktor, który przyjmuje warości domyślne -> jak w przykładzie: 
        {
            Id = 1;
            FirstName = "Przemek";
            LastName = "Mróz";
            Age = 39;
        }


        // konstruktor, który wywoływany jest z parametrami: 
        public Person(int Id, string FirstName, string LastName, string Adrress, int Age, string Gender)
        {
            this.Id = Id; // słowo this oznacza, że przypisujemy do właściwości Id wartość zmiennej Id z konstruktora
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Adrress = Adrress;
            this.Age = Age;
            this.Gender = Gender;

        }

        public Person(int Id, string FirstName, string LastName)
        {
            this.Id = Id; // słowo this oznacza, że przypisujemy do właściwości Id wartość zmiennej Id z konstruktora
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Adrress = "Łąkie";
            this.Age = 18;
        }

        public Person(int Id, string FirstName)
        {
            this.Id = Id; // słowo this oznacza, że przypisujemy do właściwości Id wartość zmiennej Id z konstruktora
            this.FirstName = FirstName;
        }
    }
}
