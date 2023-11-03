namespace D12_2._10
{
    using System;

    class Program
    {
        static void Main()
        {
            // Skapa en array A som innehåller värdena
            int[] A = { 4, 3, 9, 2, 5, 10, 6, 1, 7, 8 };

            // Skriv ut innehållet i arrayen
            Console.WriteLine("Innehållet i arrayen A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();

            // Gå igenom elementen i arrayen och om A[i]<A[i+1], byt plats på A[i] och A[i+1]
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] < A[i + 1])
                {
                    int temp = A[i];
                    A[i] = A[i + 1];
                    A[i + 1] = temp;
                }
            }

            // Skriv ut innehållet i arrayen efter att ha bytt plats på elementen
            Console.WriteLine("Innehållet i arrayen A efter att ha bytt plats på elementen:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}