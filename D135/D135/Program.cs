namespace D135
{
    using System;

    class Program
    {
        static void Main()
        {
            double[] A = { 2.5, 7.2, 4 };
            Console.WriteLine(AltSumArray(A));  // -0.7

            double[] B = { 1, -0.3, 1.1 };
            Console.WriteLine(AltSumArray(B));  // 2.4

            double[] C = { 1.1, -2.0, 1 };
            Console.WriteLine(AltSumArray(C));  // 4.1
        }

        static double AltSumArray(double[] array)
        {
            double altSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                // Om indexet är jämnt, lägg till elementet till summan
                // Om indexet är udda, subtrahera elementet från summan
                altSum += (i % 2 == 0) ? array[i] : -array[i];
            }
            return altSum;
        }
    }
}