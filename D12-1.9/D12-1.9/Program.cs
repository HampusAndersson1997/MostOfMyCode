namespace D12_1._9
{
    using System;

    class Program
    {
        static void Main()
        {
            // Skapa en array A som innehåller värdena
            int[] A = { 4, 3, 9, 2, 5, 10, 6, 1, 7, 8 };

            // Hitta det minsta och största värdet i arrayen
            int min = A[0];
            int max = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }

                if (A[i] > max)
                {
                    max = A[i];
                }
            }

            // Skriv ut det minsta och största värdet
            Console.WriteLine($"Det minsta värdet är: {min}");
            Console.WriteLine($"Det största värdet är: {max}");
        }
    }
}