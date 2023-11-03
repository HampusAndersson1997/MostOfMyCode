internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;
        int n = 1;
        
        while (n <= 10)
        {
            sum = sum + n;
            Console.WriteLine(n + " " + sum + " " + (n * n + n) / 2);
            n = n + 1;
        }
    }
}