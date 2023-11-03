namespace D137
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] I1 = { 18, 13, 17, -2, 7, 19, 21, 19, 7, 21, 7, 15, 0, 8, 0 };
            Console.WriteLine(AreValuesInRange(I1));  // false

            int[] I2 = { 20, 1, 10, 0, 20, 18, 8, 10, 11, 2, 4, 5, 11, 12, 20 };
            Console.WriteLine(AreValuesInRange(I2));  // true
        }

        static bool AreValuesInRange(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 || array[i] > 20)
                {
                    return false;
                }
            }
            return true;
        }
    }
}