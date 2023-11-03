namespace D132
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(Between(1, 2, 3));  // true
            Console.WriteLine(Between(0, 0, 3));  // true
            Console.WriteLine(Between(1, 4, 4));  // true
            Console.WriteLine(Between(1, 0, 8));  // false
            Console.WriteLine(Between(2, 5, 4));  // false
        }

        static bool Between(double minValue, double compareValue, double maxValue)
        {
            return minValue <= compareValue && compareValue <= maxValue;
        }
    }
}