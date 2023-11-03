using System.Threading.Channels;

namespace dtp1._2
{
    internal class Program
    {
        static void Main(string[] args) /// Kolla svaret i moodle ///
        {
            string[] svenska = new string[10];
            string[] latin = new string[10];
            int nästa_instättning = 0;
            svenska[nästa_instättning] = "år"; latin[nästa_instättning] = "annum";
            nästa_instättning++;
            svenska[nästa_instättning] = "träd"; latin[nästa_instättning] = "arbor";
            nästa_instättning++;

            Console.WriteLine("Hej och välkommen till latinsk ordlista!");
            Console.WriteLine("Skriv 'sluta' för att sluta!");
            bool ready = false;
            while (!ready)
            {
                Console.Write("> ");
                string kommando = Console.ReadLine();
                if (kommando == "sluta")
                {
                    Console.WriteLine("Hej då!");
                    ready = true;
                }
                else if (kommando == "hjälp")
                {
                    Console.WriteLine("hjälp    visa en lista på alla kommandon och en förklaring");
                    Console.WriteLine("latin    slå upp ett svenskt ord och få den latinska översättningen");
                    Console.WriteLine("ny       programmet frågar efter latin sedan svenska, uppslaget läggs in i ordlistan");
                    Console.WriteLine("sluta    programmet avslutas");
                    Console.WriteLine("svenska  slå upp ett latinskt ord och få den svenska översättningen");
                    Console.WriteLine("ta bort  vi tar bort ett uppslag ur ordlistan");
                    Console.WriteLine("visa     alla uppslag i ordlistan visas\r\n");
                    ready = true;
                }
                else if (kommando == "visa")
                {
                    for (int i = 0; i < nästa_instättning; i++)
                    {
                        // TODO: snyggare fromatering!!
                        Console.WriteLine($"{svenska[i]} - {latin[i]}");
                    }
                }
                else if (kommando == "ny")
                {
                    Console.WriteLine("Ange svenskt ord: ");
                    string svenskt_ord = Console.ReadLine();
                    Console.WriteLine("Ange latinsk översättning: ");
                    string latin_ord = Console.ReadLine();
                    svenska[nästa_instättning] = svenskt_ord; latin[nästa_instättning] = latin_ord;
                    nästa_instättning++;
                }
                else if (kommando == "latin")
                {
                    Console.WriteLine("Ange svenskt ord: ");
                    string svenskt_ord = Console.ReadLine();
                    int kolla_här;
                    for (kolla_här = 0; kolla_här < nästa_instättning; kolla_här++)
                    {
                        if (svenska[kolla_här] == svenskt_ord)
                        {
                            Console.WriteLine($"Latinsk översättning: {latin[kolla_här]}");
                        }
                    }
                    // TODO: kolla om det inte fanns, isf skriv FANNS INTE!
                }
                else if (kommando == "svenska")
                {
                    Console.WriteLine("Ange latinskt ord: ");
                    string latinskt_ord = Console.ReadLine();
                    int kolla_här;
                    for (kolla_här = 0; kolla_här < nästa_instättning; kolla_här++)
                    {
                        if (latin[kolla_här] == latinskt_ord)
                        {
                            Console.WriteLine($"Svensk översättning: {svenska[kolla_här]}");
                        }
                    }
                    // TODO: kolla om det inte fanns, isf skriv FANNS INTE!
                }
                else if (kommando == "ta bort")
                {
                    Console.WriteLine("Ange index(heltal) där du vill ta bort: ");
                    int ta_bort = int.Parse(Console.ReadLine());
                    // TODO felhantering om det inte är ett heltal inom inom tabellens index
                    Console.WriteLine($"Ta bort element {ta_bort}: {svenska[ta_bort]} - {latin[ta_bort]}");
                    for (int i = ta_bort; i < nästa_instättning; i++) //TODO det kanske ska va i < nästa_instättning -1
                    {
                        svenska[i] = svenska[i + 1];
                        latin[i] = latin[i + 1];
                    }
                }
                else
                {
                    Console.WriteLine($"Okänt kommando: {kommando}");
                }
            }
        }
    }
}