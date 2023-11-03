namespace D12_1._8
{
    using System;

    class Program
    {
        static void Main()
        {
            // Skapa en 50 element stor array av bool:s, och initiera alla med true
            bool[] primes = new bool[50];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            // För alla tal mellan 2 och 49, loopa igenom vart annat, vart tredje, vart fjärde, o.s.v. värde och sätt dem till false
            for (int i = 2; i * i <= primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    for (int j = i * i; j < primes.Length; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            // Gå igenom hela arrayen och kolla vilka index som är true, samt skriv ut index på dem som är sanna
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}