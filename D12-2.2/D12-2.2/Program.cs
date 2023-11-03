namespace D12_2._2
{
    using System;

    class Program
    {
        static void Main()
        {
            // Skapa en array med förnamn
            string[] namn = { "Adam", "Berith", "Caesar", "Deborah", "Erik", "Fanny" };

            // Skriv ut namnen med en foreach-loop
            foreach (string name in namn)
            {
                Console.WriteLine(name);
            }
        }
    }
}