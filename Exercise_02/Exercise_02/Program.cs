namespace Exercise_02
{
    internal class Program
    {
        static double InvSqr(double x)
        {
            return 1 / (x * x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(InvSqr(1)); // Expected: 1
            Console.WriteLine(InvSqr(2)); // Expected: 0.25
            Console.WriteLine(InvSqr(3)); // Expected: ~0.111111111111111
            Console.WriteLine(InvSqr(4)); // Expected: 0.0625
            Console.WriteLine(InvSqr(5)); // Expected: 0.04
        }
    }
}