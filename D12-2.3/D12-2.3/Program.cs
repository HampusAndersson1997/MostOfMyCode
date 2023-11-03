namespace D12_2._3
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] namn = { "Adam", "Berith", "Caesar", "Deborah", "Erik", "Fanny" };
            string[] telefonnummer = { "123-456-7890", "234-567-8901", "345-678-9012", "456-789-0123", "567-890-1234", "678-901-2345" };

            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine($"{namn[i]}'s telefonnummer är {telefonnummer[i]}");
            }
        }
    }
}