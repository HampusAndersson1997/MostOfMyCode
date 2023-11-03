namespace D12_2._11
{
    using System;

    class Program
    {
        static void Main()
        {
            // Skapa en array A som innehåller värdena
            int[] A = { 4, 3, 9, 2, 5, 10, 6, 1, 7, 8 };

            // Utför operationen 9 gånger
            for (int k = 0; k < 9; k++)
            {
                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (A[i] < A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }

            // Skriv ut innehållet i arrayen efter att ha utfört operationen
            Console.WriteLine("Innehållet i arrayen A efter att ha utfört operationen:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}