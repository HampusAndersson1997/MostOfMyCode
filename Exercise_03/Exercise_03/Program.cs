using System;

namespace Exercise_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number 1: ");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("input number 2: ");
            int end = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"sum = {sum}");
        }
    }
}