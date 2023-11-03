namespace D11_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0, prod = 1;
            do
            {
                s = s + 1; 
                prod = prod * s;
                Console.WriteLine($"s = {s}, prod = {prod}");
            } while ( s < 10 );

            Console.Write("Hur många tal vill du mata in: ");
            int n = int.Parse(Console.ReadLine());

            double summa = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Ange tal {i}: ");
                double tal = double.Parse(Console.ReadLine());
                summa += tal;
            }
            double medelvarde = summa / n;

            Console.WriteLine($"Summa = {summa}");
            Console.WriteLine($"Medelvärde = {medelvarde}");
        }
    }
}