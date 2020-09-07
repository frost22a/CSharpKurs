using System;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;

        static void Main(string[] args)
        {

            //Console.WriteLine("Podaj swój wiek:");
            //age = int.Parse(Console.ReadLine());
            //string test = age > 18 ? "pełnoletni" : "dzieckiem";
            //Console.WriteLine($"jesteś {test}");

            //Console.WriteLine("Podaj swój wiek:");
            //age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Jak masz na imię:");
            //name = Console.ReadLine();
            // instructionif();


            //Console.WriteLine("Podaj imię:");
            //name = Console.ReadLine();

            //instructionswitch();

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 2; a++)
                {
                    Console.WriteLine("wartość i: {0} oraz warość {1}", i, a);
                }
                
            }

            int e = 1;
            while (e < 3)
            {
                Console.WriteLine("wartość i: {0}", e);
                e++;
            }

            int f = 1;
            do
            {
                Console.WriteLine(f);
                f++;
            } while (f<3);

            int[] tab = { 1, 2, 3, 4 ,8 ,12};
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }

        private static void instructionswitch()
        {
            switch (name)
            {
                case "Marcin":
                    Method1();
                    break;
                case "Tomek":
                    Method2();
                    Method3();
                    break;
                default:
                    Method4();
                    break;
            }
        }

        private static void instructionif()
        {
            if (age <= 10)
            {
                if (name == "Marcin")
                {
                    Method1();
                }

            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age < 30)
            {
                Method3();
            }
            else
            {
                Method4();
            }
        }

        private static void Method4()
        {
            Console.WriteLine("Masz więcej niż 30 lat, a dokładnie " + age);
        }

        private static void Method3()
        {
            Console.WriteLine("Twój wiek jest większy do 20 i mnijeszy od 30, masz " + age + " lat");
        }

        private static void Method2()
        {
            Console.WriteLine("Twój wiek jest większy do 10 i mnijeszy od 20, masz " + age + " lat");
        }

        private static void Method1()
        {
            Console.WriteLine("Masz 10 lub mniej lat, masz dokładnie " + age + " lat");
        }
    }
}
