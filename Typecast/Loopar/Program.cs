using Microsoft.VisualBasic;

namespace Loopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int prod = 1;

            do
            {
                s = s + 1;
                prod = prod * s;
                Console.WriteLine($"s = {s}, prod = {prod}");
            } while (s < 10);
        }
        
    }
}