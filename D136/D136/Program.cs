namespace D136
{
    using System;

    class Program
    {
        static void Main()
        {
            double[] A = { 2.5, 7.2, 4 };
            double[] reversedA = ReverseArray(A);

            // Skriv ut elementen i den omvända arrayen
            for (int i = 0; i < reversedA.Length; i++)
            {
                Console.Write(reversedA[i] + " ");
            }
        }

        static double[] ReverseArray(double[] array)
        {
            double[] reversedArray = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }

            return reversedArray;
        }
    }
}