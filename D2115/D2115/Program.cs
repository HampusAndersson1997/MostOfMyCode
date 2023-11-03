using System;
namespace D2115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kronorPerLimpa = 25.5;
            double kronorPerAskMargarin = 34.9;
            double kronorPerLiterMjölk = 14.5;

            double totalKostnad = (kronorPerLimpa * 2) + kronorPerAskMargarin + kronorPerLiterMjölk;

            Console.WriteLine($"Kostnad per limpa: {kronorPerLimpa} kr");
            Console.WriteLine($"Kostnad per ask margarin: {kronorPerAskMargarin} kr");
            Console.WriteLine($"Kostnad per liter mjölk: {kronorPerLiterMjölk} kr");
            Console.WriteLine($"Total kostnad: {totalKostnad} kr");
        }
    }
}