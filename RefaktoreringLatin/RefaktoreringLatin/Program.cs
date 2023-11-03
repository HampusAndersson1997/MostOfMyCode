namespace RefaktoreringLatin
{
    internal class Program
    {
        class LatSwe
        {
            public string svenska, latin;
            public LatSwe(string latin, string svenska)
            {
                this.svenska = svenska; this.latin = latin;
            }
        }
        static List<LatSwe> glosor = new List<LatSwe>();
        static void LäggTillOrdpar(string latinord, string svenskaord)
        {
            glosor.Add(new LatSwe(latinord, svenskaord));
        }
        private static void InitieraOrdlista()
        {
            LäggTillOrdpar("arbor", "träd");
            LäggTillOrdpar("caput", "huvud");
            LäggTillOrdpar("luna", "måne");
            LäggTillOrdpar("movere", "flytta");
            LäggTillOrdpar("alea", "tärning");
            LäggTillOrdpar("iactare", "kasta");
            LäggTillOrdpar("urbs", "stad");
            LäggTillOrdpar("videre", "se");
            LäggTillOrdpar("annum", "år");
        }
        static string Input(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            InitieraOrdlista();

            Console.WriteLine("Hej och välkommen till latinsk ordlista!");
            Console.WriteLine("Skriv 'hjälp' för att få hjälp!");
            Console.WriteLine("Skriv 'sluta' för att sluta!");
            bool ready = false;
            while (!ready)
            {
                string kommando = Input("> ");
                if (kommando == "sluta")
                {
                    Console.WriteLine("Hej då!");
                    ready = true;
                }
                else if (kommando == "hjälp")
                {
                    SkrivHjälpText();
                }
                else if (kommando == "visa")
                {
                    VisaOrdlista();
                }
                else if (kommando == "ny")
                {
                    SättInNyÖversättning();
                }
                else if (kommando == "latin")
                {
                    VisaLatinskÖversättning();
                }
                else if (kommando == "svenska")
                {
                    VisaSvenskÖversättning();
                }
                else if (kommando == "ta bort")
                {
                    TaBortÖversättning();
                }
                else
                {
                    Console.WriteLine($"Okänt kommando: {kommando}");
                }
            }
        }

        private static void SkrivHjälpText()
        {
            Console.WriteLine("hjälp     visa en lista på alla kommandon och en förklaring");
            Console.WriteLine("latin     slå upp ett svenskt ord och få den latinska översättningen");
            Console.WriteLine("ny        programmet frågar efter latin sedan svenska, uppslaget läggs in i ordlistan");
            Console.WriteLine("sluta     programmet avslutas");
            Console.WriteLine("svenska   slå upp ett latinskt ord och få den svenska översättningen");
            Console.WriteLine("ta bort   vi tar bort ett uppslag ur ordlistan");
            Console.WriteLine("visa      alla uppslag i ordlistan visas");
        }

        private static void VisaOrdlista()
        {
            for (int glos_nr = 0; glos_nr < glosor.Count; glos_nr++)
            {
                Console.WriteLine($"{glos_nr}: {glosor[glos_nr].svenska} - {glosor[glos_nr].latin}");
                // TODO: snyggare formatering!!
            }
        }

        private static void SättInNyÖversättning()
        {
            string svenskt_ord = Input("Ange svenskt ord");
            string latin_ord = Input("Ange latinsk översättning: ");
            LäggTillOrdpar(latin_ord, svenskt_ord);
        }

        private static void VisaLatinskÖversättning()
        {
            string svenskt_ord = Input("Ange svenskt ord");
            int kolla_här;
            for (kolla_här = 0; kolla_här < glosor.Count; kolla_här++)
            {
                if (glosor[kolla_här].svenska == svenskt_ord)
                {
                    Console.WriteLine($"Latinsk översättning: {glosor[kolla_här].latin}");
                }
            }
            // TODO: kolla om det inte fanns, i så fall skriv FANNS INTE!
        }

        private static void VisaSvenskÖversättning()
        {
            string latinskt_ord = Input("Ange latinskt ord: ");
            int kolla_här;
            for (kolla_här = 0; kolla_här < glosor.Count; kolla_här++)
            {
                if (glosor[kolla_här].latin == latinskt_ord)
                {
                    Console.WriteLine($"Svensk översättning: {glosor[kolla_här].svenska}");
                }
            }
            // TODO: kolla om det inte fanns, i så fall skriv FANNS INTE!
        }
        static void TaBortÖversättning()
        {
            int ta_bort = int.Parse(Input("Ange index där du vill ta bort: "));
            // TODO felhantering om det inte är ett heltal inom in tabellens index
            // FIXME:felhantering om det inte funkar på sista elementet
            Console.WriteLine($"Tar bort element {ta_bort}: {glosor[ta_bort].svenska} - {glosor[ta_bort].latin}");     
            glosor.RemoveAt(ta_bort);
        }
    }
}