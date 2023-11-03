namespace D214
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            float antalMil = 20.3f;
            float literBensinPerMil = 0.7f;

            float literBensinBränsleåtgång = antalMil * literBensinPerMil;

            Console.WriteLine("Antal mil: " + antalMil);
            Console.WriteLine("Liter bensin per mil: " + literBensinPerMil);
            Console.WriteLine("Total bränsleåtgång i liter: " + literBensinBränsleåtgång);
        }
    }
}