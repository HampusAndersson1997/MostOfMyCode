namespace D12_1._7
{
    using System;

    class Program
    {
        static void Main()
        {
            // Skapa en array med de tio första primtalen
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            // Gå igenom alla dessa primtal och skriv ut dem och deras kvadrater
            for (int i = 0; i < primes.Length; i++)
            {
                Console.WriteLine($"{primes[i]} {primes[i] * primes[i]}");
            }
        }
    }
}