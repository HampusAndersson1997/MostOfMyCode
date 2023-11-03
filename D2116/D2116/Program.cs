using System;
namespace D2116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange din ålder i år: ");
            int ålder = int.Parse(Console.ReadLine());

            int sekunderPerMinut = 60;
            int minuterPerTimme = 60;
            int timmarPerDygn = 24;
            double dygnPerÅr = 365.25;

            double sekunderPerÅr = sekunderPerMinut * minuterPerTimme * timmarPerDygn * dygnPerÅr;
            double ålderISekunder = ålder * sekunderPerÅr;

            Console.WriteLine("Din ålder i sekunder är: " + ålderISekunder);
        }
    }
}