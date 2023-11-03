namespace D11_svårast
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 2; i <= 17; i++)
            {
                Console.WriteLine($"{i} {IsPrime(i)}");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}