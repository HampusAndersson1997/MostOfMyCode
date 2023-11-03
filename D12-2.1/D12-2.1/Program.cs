namespace D12_2._1
{
    using System;

    class Program
    {
        static void Main()
        {
            // Skapa en array med förnamn
            string[] namn = { "Adam", "Berith", "Caesar", "Deborah", "Erik", "Fanny" };

            // Skriv ut namnen med en for-loop
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }

}