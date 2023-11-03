namespace D12_2._4
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] namn = { "Adam", "Berith", "Caesar", "Deborah", "Erik", "Fanny" };
            string[] telefonnummer = { "0701234567", "0739876543", "0763456789", "0798765432", "0722345678", "0756789123" };

            string söktNamn = "Deborah";
            bool hittad = false;

            for (int i = 0; i < namn.Length; i++)
            {
                if (namn[i] == söktNamn)
                {
                    Console.WriteLine($"{söktNamn}'s telefonnummer är {telefonnummer[i]}");
                    hittad = true;
                    break; // Avsluta loopen när Deborah har hittats.
                }
            }

            if (!hittad)
            {
                Console.WriteLine($"{söktNamn} hittades inte i listan.");
            }
        }
    }
}