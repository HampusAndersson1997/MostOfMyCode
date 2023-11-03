using System;

namespace inl3_uppg1
{
    internal class Program
    {
        // 4. Up here there should be a static method Func with two parameters X and Y
        static double Func(double X, double Y)
        {
            double Z = 2 * X + Y / 4;
            return Z;
        }
        public static void Main(string[] args)
        {
            // 1. Correct the line below so that the next line prints 0.4!!
            double a = 2.0 / 5.0;              // <-- Change here!
            Console.WriteLine($"a = {a}"); // <-- Should give "a = 0.4"

            // 2. Make a loop that prints the int array:
            int[] I = new int[] { 99, 12, 4, 7, 33 };
            // insert the loop here!
            foreach (int element in I)
            {
                Console.WriteLine(element);
            }

            // 3. Make a loop that prints the elements of the int array that are greater than 5:
            int[] J = new int[] { 2, 1, 5, 0, 4, 2, 7, 2, 7, 2, 0, 2, 8, 3, 2 };
            // insert the loop here!
            foreach (int element in J)
            {
                if (element > 5)
                {
                    Console.WriteLine(element); 
                }
            }

            // 4. Make a static method Func that replaces the calculation expression 2 * X + Y / 4 below:
            double X = 2.3;
            double Y = 12.8;
            double Z = Func(X, Y);// <-- this line should be replaced with double Z = Func(X, Y);
            Console.WriteLine(Z); // Should give 7.8
        }
    }
}