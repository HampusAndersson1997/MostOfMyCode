using System;
namespace CsharpRepetition
{
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            // 36.
            string[] strings = { "abra", "kadabra", "hokus", "pokus", "filiokus", "sim", "sala", "bim" };
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == "sim")
                {
                    Console.WriteLine($"Index för 'sim' är: {i}");
                }
            }
            // 37.
            int[] arr1 = { 1, 5, 8, 4, 3, 7, 6, 2, 10, 9 };
            Array.Reverse(arr1);
            foreach (int num in arr1)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            // 38.
            int[] arr2 = { 4, 4, 4, 4, 5, 6, 7, 5, 4, 3 };
            int count4 = 0, count5 = 0;
            foreach (int num in arr2)
            {
                if (num == 4) count4++;
                if (num == 5) count5++;
            }
            Console.WriteLine($"Antal 4:or: {count4}, Antal 5:or: {count5}");
            // 39.
            int sum = 0, product = 1;
            foreach (int num in arr2)
            {
                sum += num;
                product *= num;
            }
            Console.WriteLine($"Summa: {sum}, Produkt: {product}");
            // 40.
            int[] arr3 = new int[100];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = 100 - i;
                if (arr3[i] != arr3.Length - i)
                {
                    Console.WriteLine($"Fel på index {i}!");
                }
            }
            // 41.
            int[] arr4 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < arr4.Length - 1; i++)
            {
                arr4[i] = arr4[i + 1];
            }
            foreach (int num in arr4)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            // 42.
            int[] rarr = new int[1000];
            for (int i = 0; i < rarr.Length; i++)
            {
                rarr[i] = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            }
            // 43.
            int[] stat = new int[19];
            foreach (int value in rarr)
            {
                stat[value]++;
            }
            for (int i = 0; i < stat.Length; i++)
            {
                Console.WriteLine($"{i}: {stat[i]}");
            }
        }
    }
}