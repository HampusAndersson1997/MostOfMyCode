namespace Ordräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFile;
            if (args.Length > 0)
            {
                textFile = args[0];
            }
            else
            {
                Console.Write("Ange filnamn: ");
                textFile = Console.ReadLine();
            }
            using (StreamReader file = new StreamReader(textFile))
            {
                int lineCounter = 0;
                int charCounter = 0;
                int wordCounter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    lineCounter++;
                    charCounter += ln.Length + 1;
                    string[] words = ln.Split(' ');
                    wordCounter += words.Length;
                }
                file.Close();
                Console.WriteLine($"Number of lines in {textFile}: {lineCounter}");
                Console.WriteLine($"Number of characters in {textFile}: {charCounter}");
                Console.WriteLine($"Number of words in {textFile}: {wordCounter}");
            }
        }
    }
}