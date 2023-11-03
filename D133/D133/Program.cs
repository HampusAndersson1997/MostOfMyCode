namespace D133
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(Poly2(2, 3, 4, 7));    // 123
            Console.WriteLine(Poly2(2, 3, 4, 3));    // 31
            Console.WriteLine(Poly2(1, 0, 1, 2.7));  // 8.29
            Console.WriteLine(Poly2(1, -2, 1, 2.4)); // 1.96
        }

        static double Poly2(double a, double b, double c, double x)
        {
            return a*x*x + b*x + c;
        }
    }
}