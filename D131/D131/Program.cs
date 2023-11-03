using System;
namespace D131
{
    class Program
    {
        static void Main()
        {
            PrintContactInfo("Arne", "Svensson", "013-113 13 13");
        }
        static void PrintContactInfo(string förnamn, string efternamn, string telefonnummer)
        {
            Console.WriteLine($"Namn: {förnamn} {efternamn}\nTelefon: {telefonnummer}");
        }
    }
}