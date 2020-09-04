using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy obiekt klasy person:
            Person person1 = new Person();
            Person person2 = new Person(1, "Tomek");
            Person person3 = new Person(2, "Tomek", "Nowak");
            Person person4 = new Person(2, "Tomek", "Nowak", "Katowice", 18, "mężczyzna");

        }
    }
}
