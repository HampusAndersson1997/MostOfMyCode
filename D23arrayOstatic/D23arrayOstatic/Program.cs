using System;

namespace D23arrayOstatic
{
    public class ArrayOperations
    {
        public static double Sum(double[] arr)
        {
            double sum = 0;
            foreach (double value in arr)
            {
                sum += value;
            }
            return sum;
        }

        public static double Average(double[] arr)
        {
            if (arr.Length == 0) return 0; // Prevent division by zero
            return Sum(arr) / arr.Length;
        }

        public static double[] Copy(double[] arr)
        {
            return (double[])arr.Clone();
        }

        public static double[] ReverseCopy(double[] arr)
        {
            double[] reversed = Copy(arr);
            Array.Reverse(reversed);
            return reversed;
        }

        public static double[] SortAndCopy(double[] arr)
        {
            double[] sorted = Copy(arr);
            InsertionSort(sorted);
            return sorted;
        }

        private static void InsertionSort(double[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                double key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Test code (replace with your own code)
            double[] numbers = { 5.5, 3.3, 7.7, 1.1, 4.4 };
            Console.WriteLine("Original Array:");
            PrintArray(numbers);

            double sum = ArrayOperations.Sum(numbers);
            Console.WriteLine($"Sum: {sum}");

            double average = ArrayOperations.Average(numbers);
            Console.WriteLine($"Average: {average}");

            double[] copied = ArrayOperations.Copy(numbers);
            Console.WriteLine("Copied Array:");
            PrintArray(copied);

            double[] reversed = ArrayOperations.ReverseCopy(numbers);
            Console.WriteLine("Reversed Array:");
            PrintArray(reversed);

            double[] sorted = ArrayOperations.SortAndCopy(numbers);
            Console.WriteLine("Sorted Array:");
            PrintArray(sorted);
        }

        static void PrintArray(double[] arr)
        {
            foreach (double value in arr)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
        }
    }
}
