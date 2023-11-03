namespace D138
{
    using System;

    class Program
    {
        static void Main()
        {
            double[] A = { 2.5, 7.2, 4 };
            Console.WriteLine(ÄrAllaInomIntervall(A, 0.0, 10.0)); // true

            double[] B = { 1, -0.3, 1.1, 3.0 };
            Console.WriteLine(ÄrAllaInomIntervall(B, 0.0, 10.0)); // false
        }

        static bool ÄrAllaInomIntervall(double[] array, double minGräns, double maxGräns)
        {
            foreach (double värde in array)
            {
                if (värde < minGräns || värde > maxGräns)
                {
                    return false;
                }
            }
            return true;
        }
    }
}