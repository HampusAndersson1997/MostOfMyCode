using System;

namespace D141
{
    class Program
    {
        public class Person
        {
            public string fornamn;
            public string efternamn;
            public string telnr;
            public string adress;

            public void Print()
            {
                Console.WriteLine($"Namn: {fornamn} {efternamn}");
                Console.WriteLine($"Telefon: {telnr}");
                Console.WriteLine($"Adress: {adress}");
            }
        }

        public static void PrintPerson(Person p)
        {
            Console.WriteLine($"Namn: {p.fornamn} {p.efternamn}");
            Console.WriteLine($" Telefon: {p.telnr}");
            Console.WriteLine($" Adress: {p.adress}");
        }

        static void Main(string[] args)
        {
            Person arne = new Person()
            {
                fornamn = "Arne",
                efternamn = "Svensson",
                telnr = "013-113 13 13",
                adress = "Datasvägen 23"
            };

            PrintPerson(arne);

            Person berith = new Person()
            {
                fornamn = "Berith",
                efternamn = "Qvist",
                telnr = "014-114 14 14",
                adress = "Telegränd 45"
            };

            berith.Print();
        }
    }
}