using System;

namespace _5
{
    public static class MathUtility
    {
        public static double InverseSum(int m, int n)
        {
            double sum = 0;

            for (int i = m; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TestInverseSum(2, 10);
            TestInverseSum(6, 11);
            TestInverseSum(7, 9);
        }

        static void TestInverseSum(int m, int n)
        {
            Console.WriteLine("input number 1: " + m);
            Console.WriteLine("input number 2: " + n);
            Console.WriteLine("sum = " + MathUtility.InverseSum(m, n));
            Console.WriteLine();
        }
    }
}