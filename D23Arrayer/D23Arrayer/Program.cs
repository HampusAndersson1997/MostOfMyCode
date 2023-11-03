namespace D23Arrayer
{
    internal class Program
    {
        private static Random rand = new Random();
        static void Main(string[] args)
        {
            DisplayIndexOfSim();
            PrintArrayInReverseOrder();
            CountOccurrencesOfNumbers();
            CalculateSumAndProduct();
            TestArrayWithNumbersInReverseOrder();
            ShiftAndPrintArrayValues();
            DisplayRandomDiceRollStatistics();
        }
        private static void DisplayIndexOfSim()
        {
            string[] words = { "abra", "kadabra", "hokus", "pokus", "filiokus", "sim", "sala", "bim" };
            int index = Array.IndexOf(words, "sim");
            Console.WriteLine($"Indexet för 'sim' är: {index}");
        }
        private static void PrintArrayInReverseOrder()
        {
            int[] numbers = { 1, 5, 8, 4, 3, 7, 6, 2, 10, 9 };
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
        private static void CountOccurrencesOfNumbers()
        {
            int[] numbers = { 4, 4, 4, 4, 5, 6, 7, 5, 4, 3 };
            int count4 = numbers.Count(n => n == 4);
            int count5 = numbers.Count(n => n == 5);
            Console.WriteLine($"Antalet 4:or i arrayen: {count4}");
            Console.WriteLine($"Antalet 5:or i arrayen: {count5}");
        }
        private static void CalculateSumAndProduct()
        {
            int[] numbers = { 4, 4, 4, 4, 5, 6, 7, 5, 4, 3 };
            int sum = numbers.Sum();
            int product = numbers.Aggregate(1, (a, b) => a * b);
            Console.WriteLine($"Summan av siffrorna i arrayen: {sum}");
            Console.WriteLine($"Produkten av siffrorna i arrayen: {product}");
        }
        private static void TestArrayWithNumbersInReverseOrder()
        {
            int[] arr = Enumerable.Range(1, 100).Reverse().ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 100 - i)
                {
                    Console.WriteLine($"Fel på index {i}!");
                }
            }
        }
        private static void ShiftAndPrintArrayValues()
        {
            int[] arr = Enumerable.Range(0, 10).ToArray();
            Array.Copy(arr, 1, arr, 0, arr.Length - 1);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        private static void DisplayRandomDiceRollStatistics()
        {
            int[] diceRollResults = new int[1000];
            for (int i = 0; i < diceRollResults.Length; i++)
            {
                diceRollResults[i] = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            }
            int[] stat = new int[19];
            foreach (var roll in diceRollResults)
            {
                stat[roll]++;
            }
            for (int i = 0; i < stat.Length; i++)
            {
                Console.WriteLine($"{i}: {stat[i]}");
            }
        }
    }
}