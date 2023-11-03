namespace D134
{
    using System;
    class Program
    {
        static void Main()
        {
            double[] A = { 2.5, 7.2, 4 };
            Console.WriteLine(SumArray(A));  // 13.7

            double[] B = { 1, -0.3, 1.1 };
            Console.WriteLine(SumArray(B));  // 1.8

            double[] C = { 1.1, -2.0, 1 };
            Console.WriteLine(SumArray(C));  // 0.1
        }
        static double SumArray(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}