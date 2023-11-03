namespace D11_1._3
{
    internal class Program
    {
        static bool IsEven(double x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsPrime(double x)
        {
            if (x / x || x / 1)
                return true;
            return false;

        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} {IsEven(i)}");
            }
        }
    }
}