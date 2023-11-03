namespace dtp_mju23v_affarsnoteprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nota = new string[30]; // 1.1.2
            int insättningsposition = 0;
            nota[insättningsposition] = "10 kg lök";
            insättningsposition++;
            nota[insättningsposition] = "2 paket smör";
            insättningsposition++;
            nota[insättningsposition] = "40 ton grädde";
            insättningsposition++;
            nota[insättningsposition] = "20 liter glass";
            insättningsposition++;
            // 1. definera sträng
            string kommando;
            Console.WriteLine("Hej och välkommen till notan! Skriv 'sluta' om du vill sluta!");
            // REPL-loop (loop)
            do
            {
                Console.Write("> ");
                kommando = Console.ReadLine();
                // TODO: ta bort skräptecken!
                Console.WriteLine("kommando: "+ kommando);
                if (kommando == "sluta")
                {
                    Console.WriteLine("Adjö!");
                }
                else if (kommando == "visa")
                {
                    Console.WriteLine("Innehåll i notan:");
                    for (int i = 0; i < insättningsposition; i++)
                    {
                        Console.WriteLine($"   {i+1}: {nota[i]}");
                    }
                }
                else if (kommando == "ny")
                {
                    Console.Write("Ange vara: ");
                    string ny_vara = Console.ReadLine();
                    nota[insättningsposition] = ny_vara;
                    insättningsposition++;
                }
                else if (kommando == "ta bort")
                {
                    Console.Write("Vilket nummer vill du ta bort: ");
                    int index_att_ta_bort = int.Parse(Console.ReadLine());
                    // TODO: ta hand om parsningsfel här om det inte är ett heltal!
                    // TODO: ta hand om absurda index!
                    Console.WriteLine($"Ska tas bort: {nota[index_att_ta_bort-1]}");
                    for (int i = index_att_ta_bort - 1; i < insättningsposition; i++)
                    {
                        // TODO: ta hand om det fall att index_ta_bort == notans storlek
                        nota[i] = nota[i + 1];
                    }
                    insättningsposition--;
                }
                else
                {
                    Console.WriteLine("Okänt kommando: " + kommando);
                }
            } while (kommando != "sluta");
            // 2. hoppa ur om "sluta"
        }
    }
}