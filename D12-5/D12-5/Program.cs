using System;

namespace D12_5
{
    class Program
    {
        static int Prod2(int m, int n)
        {
            int product = 1;
            for (int i = m; i <= n; i++)
            {
                product *= i;
            }
            return product;
        }
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(Prod2(i, j) + " ");
                }
                Console.WriteLine();
            }
        }        
    }
}