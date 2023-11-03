namespace Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(false && false);
            Console.WriteLine(false || true);
            Console.WriteLine(false && true);
            Console.WriteLine(! false);
        }
    }
}