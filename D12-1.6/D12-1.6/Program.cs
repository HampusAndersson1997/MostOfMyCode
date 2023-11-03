namespace D12_1._6
{
    using System;

    class Program
    {
        static void Main()
        {
            // Skapa en array med de tio första primtalen
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            Console.WriteLine("Primtalen mellan 10 och 20 är:");

            // Gå igenom alla dessa primtal och skriv ut dem om de är mellan 10 och 20
            foreach (int primtal in primes)
            {
                if (primtal >= 10 && primtal <= 20)
                {
                    Console.WriteLine(primtal);
                }
            }
        }
    }
}