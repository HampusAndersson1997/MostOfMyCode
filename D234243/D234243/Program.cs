namespace D234243
{
    internal class Program
    {
        static Random rand = new Random();

        static void Main()
        {
            int[] rarr = new int[1000];

            // Fyll rarr med summan av tre tärningskast
            for (int i = 0; i < rarr.Length; i++)
            {
                rarr[i] = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            }

            // Generera statistik
            int[] stat = new int[19];
            foreach (var value in rarr)
            {
                stat[value]++;
            }

            // Skriv ut statistiken
            for (int i = 0; i < stat.Length; i++)
            {
                Console.WriteLine($"{i}: {stat[i]}");
            }
        }
    }
}