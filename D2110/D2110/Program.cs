/*SKAPA en struktur för Land som innehåller:
    -Uttagstyp
    - Husvolttal
    - Frekvens*/

//SKAPA en ordbok där varje LAND kopplas till sin LANDSINFORMATION (uttagstyp, husvolttal, frekvens)

//LÄS in LAND från användaren

/*OM LAND finns i ordboken:
    HÄMTA LANDSINFORMATION för LAND
    SKRIV ut LANDSINFORMATION
ANNARS:
    SKRIV "Landet finns inte i databasen."*/
using System;
using System.Collections.Generic;

namespace D2110
{
    public struct CountryInfo
    {
        public string OutletType;
        public int ResidentVoltage;
        public int Frequency;
    
        public CountryInfo(string outletType, int residentVoltage, int frequency)
        {
            OutletType = outletType;
            ResidentVoltage = residentVoltage;
            Frequency = frequency;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, CountryInfo> countries = new Dictionary<string, CountryInfo>
            {
                {"Norge", new CountryInfo("C", 230, 50) },
                { "Finland", new CountryInfo("C", 230, 50)},
                {"United Kingdom" , new CountryInfo("G", 230, 50)},
                { "Suriname", new CountryInfo("C", 127, 60)}
            };

            Console.WriteLine("Ange namnet på ett land: ");
            string country = Console.ReadLine();

            if (countries.TryGetValue(country, out CountryInfo info))
            {
                Console.WriteLine($"För {country}: ");
                Console.WriteLine($"Uttagstyp: {info.OutletType}");
                Console.WriteLine($"Husvolttal: {info.ResidentVoltage} V");
                Console.WriteLine($"Frekvens: {info.Frequency} Hz");
            }
            else Console.WriteLine("Landet finns inte i databasen.");
        }
    }
}