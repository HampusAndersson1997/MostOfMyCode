namespace BroCode17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rows?: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = int.Parse(Console.ReadLine());

            Console.Write("What symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}