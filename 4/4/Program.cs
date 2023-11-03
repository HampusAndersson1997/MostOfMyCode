using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int firstElement = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }
            array[array.Length - 1] = firstElement;

            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
        }
    }
}