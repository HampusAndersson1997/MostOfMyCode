namespace Exerice_05
{
    internal class Program
    {
        static double SumOfInverses(int m, int n)
        {
            double sum = 0.0;
            for (int i = m; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number 1: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Input number 2: ");
            int n = int.Parse(Console.ReadLine());

            double sum = SumOfInverses(m, n);
            sum = Math.Round(sum, 15);

            Console.WriteLine($"Sum = {sum}");
        }
    }
}