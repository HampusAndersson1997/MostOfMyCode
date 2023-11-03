namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type in number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"sum = {sum}");
        }
    }
}