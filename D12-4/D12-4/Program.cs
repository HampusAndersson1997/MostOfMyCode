using System;

namespace D12_4

{
    internal class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " " + AltSumSquares(i));
            }
        }

        static int AltSumSquares(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum -= i * i;
                }
                else
                {
                    sum += i * i;
                }
            }
            return sum;
        }
    }
}