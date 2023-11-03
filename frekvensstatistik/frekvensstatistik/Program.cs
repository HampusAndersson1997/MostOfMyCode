using System.Runtime.Intrinsics.Arm;

namespace frekvensstatistik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            do
            {
                Console.WriteLine("> ");
                command = Console.ReadLine();
                if (command == "count")
                {
                    Console.Write("Enter file name: ");
                    string textFile = Console.ReadLine();
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
                else if (command == "stat")
                {
                    Console.Write("Enter file name: ");
                    string textFile = Console.ReadLine();
                    Console.WriteLine("Statistics: ");
                    int[] stat = new int[26];
                    string text = File.ReadAllText(textFile);
                    foreach (char c in text)
                    {
                        int index = c - 'a';
                        // Console.WriteLine(c + " " + index);
                        if (index >= 0 && index < 26) stat[index]++;
                    }
                    //Console.WriteLine(text);
                    for (int i = 0; i < 26; i++)
                    {
                        char ch = (char)(i+'a');
                        Console.WriteLine(ch + ": " + stat[i]);
                    }
                }
                else if (command == "quit")
                {
                    Console.WriteLine("Good byr!");
                }
            } while (command != "quit");
        }
    }
}