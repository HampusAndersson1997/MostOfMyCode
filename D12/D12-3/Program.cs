using System;

namespace D12_3
{
    class Program
    {
        static int SumSquares(int x)
        {
            int sum = 0;
            for (int i = 0; i <= x; i++)
            {
                sum += i * i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            for (int x = 1; x <= 10; x++)
            {
                int sum = SumSquares(x);
                Console.WriteLine($"{x} {sum}");
            }
        }
    }
}
