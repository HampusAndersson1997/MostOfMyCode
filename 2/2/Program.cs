namespace _2
{
    internal class Program
    {
        static double InvSqr(double x)
        {
            return 1 / (x * x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type in some number to get the inverse: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(InvSqr(x));
        }
    }
}