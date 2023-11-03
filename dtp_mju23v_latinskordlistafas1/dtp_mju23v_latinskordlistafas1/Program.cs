using System;
using System.Collections.Generic;

namespace dtp_mju23v_latinskordlistafas1
{
    class Program
    {
        static void Main(string[] args)
        {
            // D1-1.2.4. Datastrukturer
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            // Initialt mockup-uppslag
            dictionary.Add("annum", "år");
            dictionary.Add("arbor", "träd");
            dictionary.Add("caput", "huvud");
            dictionary.Add("luna", "måne");
            dictionary.Add("movere", "flytta");
            dictionary.Add("pater", "pappa");
            dictionary.Add("urbs", "stad");
            dictionary.Add("videre", "se");

            // D1-1.2.1. While-do-loop
            while (true)
            {
                Console.WriteLine("Ange ett kommando (hjälp för hjälp): ");
                var command = Console.ReadLine().ToLower();

                // D1-1.2.2. Kommandot 'sluta'
                if (command == "sluta")
                {
                    break;
                }

                // D1-1.2.3. Kommandot 'hjälp'
                if (command == "hjälp")
                {
                    Console.WriteLine("Tillgängliga kommandon:");
                    Console.WriteLine("hjälp - lista alla kommandon");
                    Console.WriteLine("latin - hitta svensk översättning för ett latinskt ord");
                    Console.WriteLine("ny - lägg till ett nytt ord i ordboken");
                    Console.WriteLine("sluta - avsluta programmet");
                    Console.WriteLine("svenska - hitta latin översättning för ett svenskt ord");
                    Console.WriteLine("ta bort - ta bort ett ord från ordboken");
                    Console.WriteLine("visa - visa alla poster i ordboken");
                }

                // D1-1.2.5. Kommandot 'visa'
                if (command == "visa")
                {
                    foreach (var entry in dictionary)
                    {
                        Console.WriteLine($"{entry.Key} - {entry.Value}");
                    }
                }

                // D1-1.2.6. Kommandot 'ny'
                if (command == "ny")
                {
                    Console.WriteLine("Ange det latinska ordet:");
                    string latin = Console.ReadLine();
                    Console.WriteLine("Ange den svenska översättningen:");
                    string swedish = Console.ReadLine();
                    dictionary[latin] = swedish;
                }

                // D1-1.2.7. Kommandot 'latin'
                if (command == "latin")
                {
                    Console.WriteLine("Ange ett svenskt ord för att få den latinska översättningen:");
                    string word = Console.ReadLine();
                    string latinTranslation = null;

                    foreach (var entry in dictionary)
                    {
                        if (entry.Value.Equals(word, StringComparison.OrdinalIgnoreCase))
                        {
                            latinTranslation = entry.Key;
                            break;
                        }
                    }

                    if (latinTranslation != null)
                        Console.WriteLine($"Latinsk översättning för {word} är: {latinTranslation}");
                    else
                        Console.WriteLine($"Ingen latinsk översättning hittades för {word}");
                }

                // D1-1.2.8. Kommandot 'svenska'
                if (command == "svenska")
                {
                    Console.WriteLine("Ange ett latinskt ord för att få den svenska översättningen:");
                    string word = Console.ReadLine();
                    if (dictionary.TryGetValue(word, out string swedishTranslation))
                        Console.WriteLine($"Svensk översättning för {word} är: {swedishTranslation}");
                    else
                        Console.WriteLine($"Ingen svensk översättning hittades för {word}");
                }

                // D1-1.2.9. Kommandot 'ta bort'
                if (command == "ta bort")
                {
                    Console.WriteLine("Ange det latinska ordet du vill ta bort:");
                    string latin = Console.ReadLine();
                    if (dictionary.ContainsKey(latin))
                    {
                        dictionary.Remove(latin);
                        Console.WriteLine($"{latin} har tagits bort från ordboken.");
                    }
                    else
                    {
                        Console.WriteLine($"{latin} hittades inte i ordboken.");
                    }
                }
            }
        }
    }
}
