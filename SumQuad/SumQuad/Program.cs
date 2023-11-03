internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            int sum = 0;
            Console.WriteLine("Skriv in sista numret i for-loopen: ");
            string max = Console.ReadLine();
            int val = Int32.Parse(max);

            if (val <= 0)
            {
                break;
            }

            for (int n = 1; n <= val; n++)
            {
                Console.WriteLine(n*n);
                sum += n*n;
            }
            Console.WriteLine("Summan 1+2+...+9 = " + sum);
        }
    }
}