using System;
namespace D2111
{
    internal class Program
    {
        //11 Static-metod Tria som tar ett heltals-argument X och returnerar uttrycket (X*X+X)/2
        public static int Tria(int X) 
        { 
            return (X*X+X)/2; 
        }

        //12 Static-metod UnitCircle som tar ett flyttals-argument X och returnerar Math.Sqrt(1-X*X)
        public static double UnitCircle(double X)
        {
            double value = 1 - X * X;
            if (value < 0) throw new InvalidOperationException("Cannot take the square root of a negative number.");
            return Math.Sqrt(value);
        }

        //13 Static-metod Inverse som returnerar 1/X
        public static double Inverse(double X) 
        {
            if (X == 0) throw new DivideByZeroException("Cannot calculate the inverse of zero.");
            return 1 / X; 
        }
        //14 Static-metod Max2 som tar två flyttal x och y, och returnerar den största av de två
        static double Max2(double x, double y)
        {
            return Math.Max(x, y);
        }
        //15 Static-metod IsEven som kontrollerar om ett heltal är jämnt eller inte
        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        //16 Static-metod IsDivisible som kontrollerar om m är jämnt delbar med n
        public static bool IsDivisible(int m, int n)
        {
            // Om n är 0, kan vi inte utföra division operationen eftersom det skulle resultera i ett undantag.
            // Så vi returnerar false i det fallet.
            if (n == 0)
            {
                return false;
            }

            return m % n == 0;
        }

        static void Main(string[] args)
        {
            //11 Beräkna Tria för 1, 2, 3 och 4
            Console.WriteLine($"Tria(1) = {Tria(1)}");
            Console.WriteLine($"Tria(2) = {Tria(2)}");
            Console.WriteLine($"Tria(3) = {Tria(3)}");
            Console.WriteLine($"Tria(4) = {Tria(4)}");

            //12 Testa UnitCircle med värdena 1, 0.5, 0, och -2
            Console.WriteLine($"UnitCircle(1) = {UnitCircle(1)}");
            Console.WriteLine($"UnitCircle(0.5) = {UnitCircle(0.5)}");
            Console.WriteLine($"UnitCircle(0) = {UnitCircle(0)}");

            try { Console.WriteLine($"UnitCircle(-2) = {UnitCircle(-2)}"); }
            catch (Exception ex) { Console.WriteLine($"Error for UnitCircle(-2): {ex.Message}"); }

            //13
            double[] testValues = { 1.5, 0.75, -2, 0 };

            foreach (var value in testValues) 
            {
                try { Console.WriteLine($"Inverse({value}) = {Inverse(value)}"); }
                catch (Exception ex) { Console.WriteLine($"Error for Inverse({value}): {ex.Message}"); }
            }

            //14
            Console.WriteLine($"Max2(3.2, 4.5) = {Max2(3.2, 4.5)}");  // Expected output: 4.5
            Console.WriteLine($"Max2(5.5, 2.8) = {Max2(5.5, 2.8)}");  // Expected output: 5.5

            //15
            Console.WriteLine($"IsEven(4) = {IsEven(4)}");  // Expected output: True
            Console.WriteLine($"IsEven(7) = {IsEven(7)}");  // Expected output: False

            //16
            Console.WriteLine($"IsDivisible(10, 2) = {IsDivisible(10, 2)}");  // Expected output: True
            Console.WriteLine($"IsDivisible(10, 3) = {IsDivisible(10, 3)}");  // Expected output: False
            Console.WriteLine($"IsDivisible(10, 0) = {IsDivisible(10, 0)}");  // Expected output: False (since dividing by zero is undefined)
        }
    }
}