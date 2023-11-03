namespace D12_2._5
{
    using System;

    class Program
    {
        public static void Main()
        {
            // Skapa en array med förnamn
            string[] namn = { "Adam", "Berith", "Caesar", "Deborah", "Erik", "Fanny" };

            // Skapa en array med telefonnummer
            string[] telefon = { "0701234567", "0739876543", "0763456789", "0798765432", "0722345678", "0756789123" };

            // Kontrollera att båda arrayerna har samma längd
            if (namn.Length != telefon.Length)
            {
                Console.WriteLine("Arrayerna har inte samma längd!");
                return;
            }

            // Sök efter Deborahs telefonnummer med hjälp av metoden HittaTelefonnummer
            string telefonnummer = HittaTelefonnummer(namn, telefon, "Deborah");

            if (telefonnummer != null)
            {
                Console.WriteLine($"Deborahs telefonnummer är: {telefonnummer}");
            }
            else
            {
                Console.WriteLine("Namnet hittades inte i listan.");
            }
        }

        public static string HittaTelefonnummer(string[] namn, string[] telefon, string sökNamn)
        {
            for (int i = 0; i < namn.Length; i++)
            {
                if (namn[i] == sökNamn)
                {
                    return telefon[i];
                }
            }

            // Returnera null om namnet inte hittades i listan
            return null;
        }
    }
}