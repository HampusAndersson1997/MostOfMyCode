namespace BroCode24
{
    internal class Program
    {
        static double Cube(double a, double b)
        {
            return a * b; // snabbare då de redan är double
            /*double z = x * y;
            return z;*/
        }
        static double Cube(double a, double b, double c)
        {
            return a * b * c;
        }
        static void Main(string[] args)
        {
            double total = Cube(2, 3, 4);

            Console.WriteLine(total);
            Console.ReadKey();

            /*double x;
            double y;
            double result;

            Console.WriteLine("Enter in number 1; ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter in number 2; ");
            y = double.Parse(Console.ReadLine());

            result = Cube(x, y);

            Console.WriteLine(result);*/

        }
    }
}