using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            foreach (var item in args)
            {
                Console.WriteLine("Witaj " + item);
            }
            Console.WriteLine("elo!");           

        }
    }
}
